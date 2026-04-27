using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace MediaManager_Chan
{
    public class VideoInfo
    {
        public string Duration { get; set; }
        public string Resolution { get; set; }
        public long FileSize { get; set; }
        public string FileSizeText { get; set; }
        public bool IsAudio { get; set; }
    }

    public static class VideoHelper
    {
        public static VideoInfo GetVideoInfo(string videoPath)
        {
            VideoInfo info = new VideoInfo();

            try
            {
              
                // 文件信息（安全获取）
               
                if (File.Exists(videoPath))
                {
                    FileInfo fileInfo = new FileInfo(videoPath);
                    info.FileSize = fileInfo.Length;
                    info.FileSizeText = $"{fileInfo.Length / 1024.0 / 1024.0:0.00} MB";
                }
                else
                {
                    info.Duration = "文件不存在";
                    info.Resolution = "-";
                    return info;
                }

            
                // ffprobe
               
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "ffprobe.exe",
                    Arguments = $"-v error -select_streams a:0 -show_entries stream=codec_type,duration -show_entries format=duration -of json \"{videoPath}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        info.Duration = "无法解析";
                        info.Resolution = "-";
                        return info;
                    }

                    dynamic json = JsonConvert.DeserializeObject(output);

                  
                    // 读时长（视频/音频通用）
                    
                    try
                    {
                        if (json?.format?.duration != null)
                        {
                            double sec = double.Parse(json.format.duration.ToString());
                            info.Duration = TimeSpan.FromSeconds(sec).ToString(@"hh\:mm\:ss");
                        }
                        else if (json?.streams?[0]?.duration != null)
                        {
                            double sec = double.Parse(json.streams[0].duration.ToString());
                            info.Duration = TimeSpan.FromSeconds(sec).ToString(@"hh\:mm\:ss");
                        }
                        else
                        {
                            info.Duration = "未知时长";
                        }
                    }
                    catch
                    {
                        info.Duration = "解析失败";
                    }

                   
                    // 判断
       
                    bool isAudio = false;
                    if (json?.streams?[0]?.codec_type != null)
                    {
                        string codecType = json.streams[0].codec_type.ToString().ToLower();
                        isAudio = codecType == "audio";
                    }
                    info.IsAudio = isAudio;

           
                    // 分辨率（音频不显示）
           
                    try
                    {
                        if (isAudio)
                        {
                            info.Resolution = "音频文件";
                        }
                        else
                        {
                            if (json?.streams?[0]?.width != null && json?.streams?[0]?.height != null)
                            {
                                int w = json.streams[0].width;
                                int h = json.streams[0].height;
                                info.Resolution = $"{w} × {h}";
                            }
                            else
                            {
                                info.Resolution = "未知分辨率";
                            }
                        }
                    }
                    catch
                    {
                        info.Resolution = isAudio ? "音频" : "获取失败";
                    }
                }
            }
            catch (Exception ex)
            {
                info.Duration = "异常";
                info.Resolution = "异常";
                info.FileSizeText = "0 MB";
            }

            return info;
        }
    }
}