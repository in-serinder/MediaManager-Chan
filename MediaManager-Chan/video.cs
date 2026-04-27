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
    }

    public static class VideoHelper
    {
        public static VideoInfo GetVideoInfo(string videoPath)
        {
            VideoInfo info = new VideoInfo();

       
            FileInfo fileInfo = new FileInfo(videoPath);
            info.FileSize = fileInfo.Length;
            info.FileSizeText = $"{fileInfo.Length / 1024.0 / 1024.0:0.00} MB";

            try
            {
      
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "ffprobe.exe",
                    Arguments = $"-v error -select_streams v:0 -show_entries stream=width,height -show_entries format=duration -of json \"{videoPath}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    dynamic json = JsonConvert.DeserializeObject(output);

                    // 读分辨率
                    if (json?.streams?[0]?.width != null && json?.streams?[0]?.height != null)
                    {
                        int w = json.streams[0].width;
                        int h = json.streams[0].height;
                        info.Resolution = $"{w} × {h}";
                    }

                    // 读时长
                    if (json?.format?.duration != null)
                    {
                        double sec = double.Parse(json.format.duration.ToString());
                        info.Duration = TimeSpan.FromSeconds(sec).ToString(@"hh\:mm\:ss");
                    }
                }
            }
            catch
            {
                info.Duration = "未知";
                info.Resolution = "未知";
            }

            return info;
        }
    }
}