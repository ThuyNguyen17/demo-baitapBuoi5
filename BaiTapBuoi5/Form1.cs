using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TaoMoiVB_Click(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TScomboFont.Text = "Tahoma";
            TScomboSize.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                TScomboFont.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                TScomboSize.Items.Add(s);
            }
        }

        private void OpenFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (filePath.EndsWith(".rtf"))
                {
                    richText.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richText.Text = System.IO.File.ReadAllText(filePath);
                }
            }
        }

        private void DinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        // Biến để lưu đường dẫn file hiện tại
        private string currentFilePath = null;

        private void TaoMoiVB_Click(object sender, EventArgs e)
        {
            richText.Clear();

            richText.Font = new Font("Tahoma", 14, FontStyle.Regular);
            richText.ForeColor = Color.Black;
            richText.BackColor = Color.White;

            // Đặt lại trạng thái lưu
            currentFilePath = null; 
            TScomboFont.SelectedItem = "Tahoma"; // Đặt lại font mặc định
            TScomboSize.SelectedItem = "14"; // Đặt lại kích thước mặc định

        }

        private void TSBLuu_Click(object sender, EventArgs e)
        {
            LuuNoiDung_Click(sender, e);
        }

        private void LuuNoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu chưa có đường dẫn lưu (văn bản mới)
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    // Tạo hộp thoại SaveFileDialog để người dùng chọn nơi lưu
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt",
                        Title = "Lưu Tập Tin Văn Bản"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Gán đường dẫn tệp người dùng chọn vào currentFilePath
                        currentFilePath = saveFileDialog.FileName;
                    }
                    else
                    {
                        // Người dùng hủy lưu, thoát hàm
                        return;
                    }
                }

                // Lưu nội dung xuống tập tin
                if (!string.IsNullOrEmpty(currentFilePath))
                {
                    if (currentFilePath.EndsWith(".rtf"))
                    {
                        // Nếu định dạng là .rtf, sử dụng phương thức SaveFile
                        richText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Nếu định dạng là .txt, lưu dưới dạng văn bản thuần túy
                        File.WriteAllText(currentFilePath, richText.Text);
                    }

                    // Thông báo lưu thành công
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có vấn đề trong quá trình lưu
                MessageBox.Show($"Không thể lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
    }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem nội dung RichTextBox có thay đổi không
            if (!string.IsNullOrEmpty(richText.Text))
            {
                // Hiển thị thông báo hỏi người dùng có muốn lưu nội dung trước khi thoát
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn lưu các thay đổi trước khi thoát không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Gọi hàm lưu nội dung trước khi thoát
                    LuuNoiDung_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    // Nếu chọn Hủy, dừng thoát
                    return;
                }
            }
            Application.Exit();
        }


        private void TSBInDam_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                // Lấy font hiện tại
                Font currentFont = richText.SelectionFont;
                // Kiểm tra 
                FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                // Thay đổi font 
                richText.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void TSBInNghieng_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                // Lấy font hiện tại
                Font currentFont = richText.SelectionFont;
                // Kiểm tra font 
                FontStyle newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
                // Thay đổi font
                richText.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void TSBGachChan_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
                richText.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void TScomboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TScomboFont.SelectedItem != null)
            {     
                string selectedFont = TScomboFont.SelectedItem.ToString();
                if (richText.SelectionFont != null)
                {                 
                    float currentSize = richText.SelectionFont.Size;

                    richText.SelectionFont = new Font(selectedFont, currentSize);
                }
                else
                {
              
                    richText.Font = new Font(selectedFont, richText.Font.Size);
                }
            }
        }

        private void TScomboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TScomboSize.SelectedItem != null)
            {              
                float selectedSize;
                if (float.TryParse(TScomboSize.SelectedItem.ToString(), out selectedSize))
                {
                    if (richText.SelectionFont != null)
                    {
                        string currentFont = richText.SelectionFont.Name;
                        richText.SelectionFont = new Font(currentFont, selectedSize);
                    }
                    else
                    {
                        richText.Font = new Font(richText.Font.Name, selectedSize);
                    }
                }
            }
        }
    }
}
