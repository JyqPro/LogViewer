using System.Text;

namespace LogViewer
{
    public partial class LogViewer : Form
    {
        private const string INFO = "[INFO ]";
        private const string TEST_ITEM_START_INFO = "[INFO ] LUA: ============================== 开始测试 ";
        private const string MARK_CHAR = "=";
        public LogViewer()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            btn_open.Click -= Btn_open_Click;
            btn_open.Click += Btn_open_Click;

            tree_testList.AfterSelect -= Tree_testList_AfterSelect;
            tree_testList.AfterSelect += Tree_testList_AfterSelect;
            btn_close.Click -= Btn_close_Click;
            btn_close.Click += Btn_close_Click;
            btn_loadLog.Click -= Btn_loadLog_Click;
            btn_loadLog.Click += Btn_loadLog_Click;

            tree_testList.DragEnter -= Tree_testList_DragEnter;
            tree_testList.DragDrop -= Tree_testList_DragDrop;
            txt_content.DragEnter -= Txt_content_DragEnter;
            txt_content.DragDrop -= Txt_content_DragDrop;
            txt_content.AllowDrop = true;
            tree_testList.AllowDrop = true;
            tree_testList.DragEnter += Tree_testList_DragEnter;
            tree_testList.DragDrop += Tree_testList_DragDrop;
            txt_content.DragEnter += Txt_content_DragEnter;
            txt_content.DragDrop += Txt_content_DragDrop;
        }

        private void Txt_content_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (paths is null || paths.Length <= 0) return;
            ReadFile(paths[0], false);
        }

        private void Txt_content_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Tree_testList_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (paths is null || paths.Length <= 0) return;
            ReadFile(paths[0]);
        }

        private void Tree_testList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Btn_loadLog_Click(object sender, EventArgs e)
        {
            ReadFile(loadTestItems: false);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Tree_testList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is null)
            {
                return;
            }
            HighlightAllMatches(txt_content, e.Node.Text);
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
        private void ReadFile(string file = "", bool loadTestItems = true)
        {
            try
            {
                var fileDialog = new OpenFileDialog
                {
                    Filter = "log文件|*.log|txt文件|*.txt",
                    Title = "选择日志文件"
                };
                if (string.IsNullOrEmpty(file))
                {
                    if (fileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

                string searchText = TEST_ITEM_START_INFO;
                string filePath = string.IsNullOrEmpty(file) ? fileDialog.FileName : file;
                var lines = File.ReadAllLines(filePath);
                var logLines = lines.Select((line, index) => line).Where(x => x.Contains(searchText));
                txt_content.Clear();
                txt_content.Lines = lines;
                var sp = new StringBuilder();
                if (loadTestItems)
                {
                    sp.AppendLine("loadtestitems");
                    tree_testList.Nodes.Clear();
                    foreach (var item in logLines)
                    {
                        var name = GetTestItemName(item);
                        var node = new TreeNode(name, 0, 0);
                        sp.AppendLine(name);
                        tree_testList.Nodes.Add(node);
                    }
                    var path = Environment.CurrentDirectory + "\\log.txt";
                    File.WriteAllText(path, sp.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取文件出错：{ex.Message}");
            }
        }
        private static string GetTestItemName(string line)
        {
            int infoIndex = line.IndexOf(INFO);
            var target = line[infoIndex..].Replace(TEST_ITEM_START_INFO, "");
            var index = target.IndexOf(MARK_CHAR);
            var result = target[..(index - 1)];
            return result;
        }
        private static void HighlightAllMatches(RichTextBox richTextBox, string searchText)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = richTextBox.BackColor;
            richTextBox.SelectionColor = richTextBox.ForeColor;

            int index = richTextBox.Find(searchText, 0, RichTextBoxFinds.None);

            if (index < 0)
            {
                return;
            }
            richTextBox.Select(index, searchText.Length);
            richTextBox.ScrollToCaret();

            richTextBox.SelectionBackColor = Color.Yellow;
            richTextBox.SelectionColor = Color.Black;

            richTextBox.Focus();
        }
    }
}
