using System.ComponentModel.DataAnnotations;

namespace MediaManager_Chan
{
    public partial class Form1 : Form
    {
        public string currentopen_path, playing_video,selected_file;
        public string[] allfiles;

        private static int clickcount = 0;
        private string lastselect;
        public Form1()
        {
            InitializeComponent();
            sort_cb.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            currentopen_path = dialog.SelectedPath;
            path_lb.Text = currentopen_path;

            loadVideos();



        }

        private void videolist_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (videolist_cb.SelectedItem == null)
                return;

            //双击播放
            clickcount++;

            if (clickcount == 2 && lastselect == videolist_cb.SelectedItem.ToString())
            {
                playvideo(videolist_cb.SelectedItem.ToString());
                clickcount = 0;
            }
            else { clickcount = 0; }
            lastselect = videolist_cb.SelectedItem.ToString();

            //当前选择文件解析
            selected_file = currentopen_path + "/" + videolist_cb.SelectedItem.ToString();
            VideoInfo videoInfo = new VideoInfo();
            videoInfo = VideoHelper.GetVideoInfo(selected_file);
            //解析到lb
            duration_lb.Text = videoInfo.Duration;
            filesize_lb.Text = utility.getSizeUtil(videoInfo.FileSize);
            videores_lb.Text = videoInfo.Resolution.ToString();

            rename_tb.Text = videolist_cb.SelectedItem.ToString();
        }

        private void sort_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //重新排序
            loadVideos();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {

            playvideo(videolist_cb.SelectedItem.ToString());
        }

        private void del_btn_Click(object sender, EventArgs e)
        {

            if (videolist_cb.CheckedItems.Count == 0)
            {
                MessageBox.Show("未选择视频");
                return;
            }

            //删除当前选择视频
            List<string> checkedList = new List<string>();
            foreach (string file in videolist_cb.CheckedItems.Cast<string>().ToList())
            {

                checkedList.Add(Path.Combine(currentopen_path, file));
            }
            DialogResult del_aaa = MessageBox.Show("将删除" + checkedList.Count + "个文件 删除无法恢复!", "确认删除?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (del_aaa != DialogResult.Yes) return;

            //正式删除
            foreach (string file in checkedList)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }

            //重加载
            loadVideos();

            MessageBox.Show("删除完成","删除",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
        private void rename_btn_Click(object sender, EventArgs e)
        {
            if (selected_file == null) return;
            File.Move(selected_file, currentopen_path + "/" + rename_tb.Text.ToString());
            //重加载
            loadVideos();

        }



        //private void playnow_lb_Paint(object sender, PaintEventArgs e)
        //{
        //    Label lbl = sender as Label;


        //    e.Graphics.Clear(lbl.BackColor);


        //    TextRenderer.DrawText(
        //        e.Graphics,
        //        lbl.Text,
        //        lbl.Font,
        //        lbl.ClientRectangle,
        //        lbl.ForeColor,
        //        TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine
        //    );


        //    e.Handled = true;
        //}



        /*自定义函数*/

        private void playvideo(string file)
        {

            playing_video = currentopen_path + "/" + file;
            player_wmp.URL = playing_video;
            playnow_lb.Text = "正在播放:" + Path.GetFileName(playing_video);
        }


        private void loadVideos()
        {
            allfiles = utility.SortFiles(utility.GetFilesByExtension(currentopen_path, ["mp4","mov","avi","mp3","flv","mkv","wav","flac","midi"]), sort_cb.Text.ToString());
            view_lb.Text = "数量:" + allfiles.Length;
            videolist_cb.Items.Clear();
            foreach (string file in allfiles)
            {
                videolist_cb.Items.Add(Path.GetFileName(file));
            }
        }




    }
}
