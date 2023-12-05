using GrapeCity.Win.MultiRow;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int GcMultiRow1_CuloumnIndex_0 = 0;
        private const int GcMultiRow1_CuloumnIndex_1 = 1;
        private const int GcMultiRow1_CuloumnIndex_2 = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var template = new Template();
            template.Width = 500;

            #region ColumnHeader Layout
            var header = new ColumnHeaderSection();
            header.Height = 40;

            header.Cells.AddRange(new[]
            {
                new ColumnHeaderCell()
                {
                    Value = "CheckBox Culoumn",
                    Location = new Point(0, 0),
                    Size = new Size(200, 40),
                    Style = new CellStyle()
                    {
                        TextAlign = MultiRowContentAlignment.MiddleCenter,
                        Multiline = MultiRowTriState.False,
                        Font = this.Font,
                        Border = new Border(LineStyle.Dotted, Color.Black)
                    }
                },
                new ColumnHeaderCell()
                {
                    Value = "TextBox Culoumn",
                    Location = new Point(200, 0),
                    Size = new Size(200, 20),
                    Style = new CellStyle()
                    {
                        TextAlign = MultiRowContentAlignment.MiddleCenter,
                        Multiline = MultiRowTriState.False,
                        Font = this.Font,
                    }
                },
                new ColumnHeaderCell()
                {
                    Value = "Button Culoumn",
                    Location = new Point(200, 20),
                    Size = new Size(200, 20),
                    Style = new CellStyle()
                    {
                        TextAlign = MultiRowContentAlignment.MiddleCenter,
                        Multiline = MultiRowTriState.False,
                        Font = this.Font,
                        Border = new Border(LineStyle.Thin, Color.Black)
                    }
                }
            });

            template.ColumnHeaders.Add(header);
            #endregion

            #region Row Cell Layout
            template.Row.Height = 40;
            template.Row.Cells.AddRange(new Cell[]
            {
                new CheckBoxCell
                {
                    Location = new Point(0, 0),
                    Size = new Size(200, 40),
                    Value = false
                },
                new TextBoxCell
                {
                    Location = new Point(200, 0),
                    Size = new Size(200, 20),
                    Value = "Default Value"
                },
                new ButtonCell
                {
                    Location = new Point(200, 20),
                    Size = new Size(200, 20),
                    Value = "Button"
                }
            });
            #endregion

            GcMultiRow1.Template = template;
        }

        private void GcMultiRow1_CellClick(object sender, CellEventArgs e)
        {
            try
            {
                if (e.CellIndex != GcMultiRow1_CuloumnIndex_2)
                    return;  //クリック処理対象外のセルがクリックされた場合はスキップ

                //以降はボタンクリック時の処理
                MessageBox.Show($"Button row no={e.RowIndex}   Button column no={e.CellIndex}   TextBox cell value={GcMultiRow1[e.RowIndex, GcMultiRow1_CuloumnIndex_1].Value}");
            }
            catch (Exception ex)
            {
                //エラーログ出力
                //エラーメッセージ表示
            }
        }

    }
}