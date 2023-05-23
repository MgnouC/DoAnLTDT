using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DoAnLTDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Graph
        {
            public int[,] matran;
            public int sodinh;
            public List<Label> dinh;
            public Graph()
            {
                matran = new int[100, 100];
                sodinh = 0;
                dinh = new List<Label>();
            }
        }
        Graph dothi = new Graph();
        void maTran(string s)
        {
            string[] strings = s.Split(new string[] { "\r\n", " " }, StringSplitOptions.RemoveEmptyEntries); // Một chuỗi được cắt thành một mảng chuỗi
            dothi.sodinh = (int)Math.Sqrt(strings.Length + 1); // Ma trận vuông nên số dòng (số đỉnh) sẽ là căn bậc 2 của số lượng phần tử
            int z = 0;
            for(int i = 0; i < dothi.sodinh; ++i)
            {
                for(int j = 0; j < dothi.sodinh; ++j)
                {
                    if (strings[z] == "-") dothi.matran[i, j] = 0; // "-" tương đương với vô cực
                    else dothi.matran[i, j] = int.Parse(strings[z]);
                    z++;
                }
            }
        }
        private void btn_VeDT_Click(object sender, EventArgs e)
        {
            if(txt_MaTran.Text.Trim().Length == 0) // Nếu chưa nhập thì ko vẽ
            {
                return;
            }
            maTran(txt_MaTran.Text);
            veDinh();
            veCanh();
            themTrongSo();
        }
        bool check2(int x,int y) // Kiểm tra để các đỉnh không bị quá gần nhau
        {
            foreach(Label l in dothi.dinh)
            {
                if (Math.Sqrt((x - l.Location.X) * (x - l.Location.X) + (y - l.Location.Y) * (y - l.Location.Y)) <= 70)
                {
                    return false;
                }
            }
            return true;
        }
        bool check(int x,int y) // Kiểm tra các đỉnh phải trên một vòng tròn để tránh trường hợp các đỉnh tạo thành một đường thẳng
        {
            if (Math.Sqrt((x - 554) * (x - 554) + (y - 354) * (y - 354)) >= 290 && Math.Sqrt((x - 554) * (x - 554) + (y - 354) * (y - 354)) <= 300)
            {
                return true;
            }
            else return false;
        }
        void themTrongSo()
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color.Black);
            Font f = new Font("Tunga", 10);
            for (int i = 0; i < dothi.sodinh; ++i)
            {
                for (int j = i + 1; j < dothi.sodinh; j++)
                {
                    if (dothi.matran[i, j] > 0)
                    {
                        // Vẽ trọng số ở giữa 2 đỉnh (trung điểm của cạnh nối 2 đỉnh đó)
                        g.DrawString(dothi.matran[i,j].ToString(),f,brush, (dothi.dinh[i].Location.X + dothi.dinh[j].Location.X)/2, (dothi.dinh[i].Location.Y + dothi.dinh[j].Location.Y) / 2);
                    }
                }
            }
        }
        void veDinh()
        {
            Random random = new Random();
            for(int i = 0; i < dothi.sodinh; ++i)
            {
                int x;
                int y;
                do
                {
                    x = random.Next(200, panel1.Width-100); // Random tọa độ x,y
                    y = random.Next(20, panel1.Height-100);
                } while (!(check2(x,y)&&check(x,y)));// Kiểm tra xem nó đúng chưa
                Label label = new Label() { Text = (i+1).ToString(), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.Gray };
                label.Location = new Point(x, y);
                label.Size = new Size(30, 30);
                label.TextAlign = ContentAlignment.MiddleCenter;
                panel1.Controls.Add(label); // Thêm label vào panel1
                dothi.dinh.Add(label);// Thêm dỉnh (label) vào list đỉnh của đồ thị
            }
        }
        void veCanh()
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black);
            for (int i = 0; i < dothi.sodinh; ++i)
            {
                for(int j = i+1; j < dothi.sodinh; j++)
                {
                    if (dothi.matran[i,j] > 0)
                    {
                        // Vẽ đường thẳng nối 2 đỉnh (2 label)
                        g.DrawLine(pen, dothi.dinh[i].Location.X + 15, dothi.dinh[i].Location.Y + 15, dothi.dinh[j].Location.X + 15, dothi.dinh[j].Location.Y + 15);
                    }
                }
            }
        }
        void danhDau(Label l1, Label l2) // Tô màu xanh cho cạnh khi chạy thuật toán prim hoặc dijkstra
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Blue,3);
            g.DrawLine(pen, l1.Location.X + 15, l1.Location.Y + 15, l2.Location.X + 15, l2.Location.Y + 15);
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
            panel1.Controls.Clear();
            dothi = new Graph();
            foreach(Control i in this.Controls)
            {
                if(i is TextBox)
                {
                    i.Text = string.Empty;
                }
            }
            txt_MaTran.Focus(); 
        }
        void duyetDT(int i, ref int[] visited)
        {
            visited[i] = 1;
            for (int j = 0; j < dothi.sodinh; j++)
                if ((visited[j] == 0) && (dothi.matran[i, j] > 0))
                //nếu đỉnh j chưa được duyệt qua (visited[j] == 0) và có kết nối từ đỉnh i đến đỉnh j (dothi.matran[i, j] > 0).
                    duyetDT(j, ref visited);
        }
        bool DTLienThong()
        {
            int[] visited = new int[dothi.sodinh];
            int soLienThong = 0; // dem so lien thong do thi 
            for (int i = 0; i < dothi.sodinh; ++i)
            {
                visited[i] = 0;//  đảm bảo rằng ban đầu không có đỉnh nào đã được duyệt qua.
            }
            for (int i = 0; i < dothi.sodinh; ++i)
            {
                if (visited[i] == 0)
                {
                    soLienThong++;
                    duyetDT(i, ref visited);
                }
            }
            if (soLienThong == 1) return true;
            else return false;
        }
        List<Tuple<int, int, int>> prim(int diemBatDau)
        {
            List<Tuple<int,int,int>> list = new List<Tuple<int,int,int>>();// 1 canh : đỉnh đầu - đỉnh cuối - trọng số
            int[] visited = new int[dothi.sodinh];
            for (int i = 0; i < dothi.sodinh; ++i)
            {
                visited[i] = 0;//đánh dấu tất cả các đỉnh chưa được duyệt qua (ban đầu có giá trị 0).
            }
            visited[diemBatDau - 1] = 1; //đánh dấu đỉnh bắt đầu (diemBatDau) là đã được duyệt qua
            while(list.Count < dothi.sodinh - 1)//số cạnh trong cây khung nhỏ nhất bằng số đỉnh trừ đi 1)
            {
                Tuple<int, int, int> canh = new Tuple<int, int, int>(0, 0, 0);
                int min = -1;// luu trữ giá trị nhỏ nhất hiện tại của cạnh.
                for(int i = 0; i < dothi.sodinh; ++i)
                {
                    if(visited[i] == 0) //kiểm tra xem đỉnh i đã được duyệt qua chưa
                    {
                        for(int j = 0; j < dothi.sodinh; ++j) // duyệt qua tất cả các đỉnh đã được duyệt qua
                        {
                            if (visited[j] == 1 && dothi.matran[i,j] != 0) 
                            // kiểm tra xem đỉnh j đã được duyệt qua và có kết nối với đỉnh i không.
                            {
                                if(min == -1 || dothi.matran[i,j] < min)
                                 //kiểm tra xem trọng số của cạnh hiện tại (dothi.matran[i, j]) có nhỏ hơn giá trị nhỏ nhất hiện tại (min) 
                                {
                                    min = dothi.matran[i,j];//cập nhật min 
                                    canh = new Tuple<int, int, int>(j,i,dothi.matran[i,j]);
                                    //cập nhật giá trị của cạnh "canh" thành (j, i, dothi.matran[i, j])

                                }
                            }
                        }
                    }
                }
                list.Add(canh);
                visited[canh.Item2] = 1;
                //Đỉnh kết thúc của cạnh "canh" được đánh dấu là đã được duyệt
                //Quay lại vòng lặp while và tiếp tục quá trình tìm kiếm cạnh tối thiểu cho đến khi danh sách list chứa đủ dothi.sodinh - 1 cạnh
            }
            return list;
        }
        private void btn_Prim_Click(object sender, EventArgs e)
        {
            try
            {
                resetDoThi();
                if (DTLienThong())

                {
                    List<Tuple<int, int, int>> list = prim(int.Parse(txt_Prim.Text));
                    string s = string.Empty;// lưu trữ chuỗi kết quả của cây khung nhỏ nhất 
                    int sum = 0;// tính tổng trọng số của cây.
                    for (int i = 0; i < list.Count; ++i)
                        // duyệt qua danh sách các cạnh của cây khung nhỏ nhất.
                    {
                        s += "(" + (list[i].Item1 + 1) + ", " + (list[i].Item2 + 1) + ") ";
                        //thêm cạnh hiện tại vào chuỗi, cùng với định dạng đỉnh bắt đầu và đỉnh kết thúc của cạnh
                        sum += list[i].Item3;
                        //trọng số của cây được tính bằng cách cộng dồn trọng số của các cạnh
                    }
                    s += "\r\n" + "Trọng số của cây: " + sum;
                    txt_ThuatToan.Text = s;
                    foreach (Tuple<int, int, int> i in list)
                        //duyệt qua danh sách các cạnh của cây khung nhỏ nhất
                    {
                        danhDau(dothi.dinh[i.Item1], dothi.dinh[i.Item2]);
                        //đỉnh bắt đầu và đỉnh kết thúc của cạnh
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    txt_ThuatToan.Text = "Không có cây khung nhỏ nhất vì đồ thị không liên thông";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<int> Dijsktra(int dinhbatdau, int dinhketthuc)
        {
            int[] trongso = new int[dothi.sodinh];
            int[] duongdi = new int[dothi.sodinh];
            bool[] check = new bool[dothi.sodinh];
            for(int i = 0; i < dothi.sodinh; ++i)
            {
                trongso[i] = 10000000;
                check[i] = false;
            }
            int dinhHT = dinhbatdau - 1;
            trongso[dinhHT] = 0;
            while(dinhHT != dinhketthuc - 1)
            {
                int trongsomin = 10000000;
                // tìm giá trị trọng số nhỏ nhất của các đỉnh chưa được duyệt qua
                for(int i = 0; i < dothi.sodinh; ++i)
                {
                    if (check[i] == false && trongsomin > trongso[i])
                    {
                        //nếu đỉnh "i" chưa được duyệt qua và có trọng số nhỏ hơn "trongsomin",
                        //thì cập nhật "trongsomin" và đỉnh hiện tại "dinhHT" với giá trị "i".
                        trongsomin = trongso[i];
                        dinhHT = i;
                    }
                }
                if(trongsomin == 10000000)
                    //không có đường đi từ đỉnh bắt đầu đến đỉnh kết thúc
                {
                    return new List<int>();
                }
                //Đánh dấu đỉnh hiện tại được duyệt qua 
                check[dinhHT] = true;
                for(int i = 0; i < dothi.sodinh; ++i)
                {
                    if (dothi.matran[dinhHT,i] != 0 && trongso[i] > trongso[dinhHT] + dothi.matran[dinhHT, i])
                    // cạnh từ đỉnh hiện tại "dinhHT" đến đỉnh "i" và
                    // trọng số hiện tại của "i" lớn hơn trọng số từ "dinhHT" đến "i" cộng với trọng số hiện tại của "dinhHT"
                    {
                        // cập nhật trọng số của "i" và đường đi của "i" là "dinhHT".
                        trongso[i] = trongso[dinhHT] + dothi.matran[dinhHT, i];
                        duongdi[i] = dinhHT;
                    }
                }
            }// tạo một danh sách "list" để lưu trữ đường đi ngắn nhất từ đỉnh bắt đầu đến đỉnh kết thúc
            List<int> list = new List<int>();
            int j = dinhketthuc - 1;
            while( j != dinhbatdau - 1)
                // lặp qua các đỉnh trước trên đường đi ngắn nhất
                // từ đỉnh kết thúc đến đỉnh bắt đầu
            {
                list.Add(j);
                j = duongdi[j];
            }
            list.Add(dinhbatdau - 1);
            list.Reverse();
            list.Add(trongso[dinhketthuc - 1]);
            return list;
        }
        private void btn_Dijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                resetDoThi();
                List<int> list = Dijsktra(int.Parse(txt_Dijkstra1.Text), int.Parse(txt_Dijkstra2.Text));
                if (list.Count == 0)
                {
                    txt_ThuatToan.Text = "Không có đường đi từ đỉnh " + txt_Dijkstra1.Text + " đến " + txt_Dijkstra2.Text;
                }
                else
                {
                    string s = string.Empty;
                    for (int i = 0; i < list.Count - 2; i++)
                    {
                        s += (list[i] + 1) + "->";
                        danhDau(dothi.dinh[list[i]], dothi.dinh[list[i + 1]]);
                        Thread.Sleep(1000); // Dừng 1 giây rồi chạy tiếp
                    }
                    s += (list[list.Count - 2] + 1) + "\r\n";
                    s += "Có trọng số là: " + list[list.Count - 1];
                    txt_ThuatToan.Text = s;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_DocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Document|*.txt";
            if(file.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(file.FileName);
                txt_MaTran.Text = "";
                while (!r.EndOfStream)
                {
                    txt_MaTran.Text += r.ReadLine() + "\r\n"; // "\r\n" là xuống dòng trong textbox
                }
                r.Close();
            }
        }
        void resetDoThi()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
            veCanh();
            themTrongSo();
        }
    }
}
