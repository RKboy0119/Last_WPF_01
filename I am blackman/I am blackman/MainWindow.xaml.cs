using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace I_am_blackman
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        // 宣告陣列
        string[] names = { "大吉", "吉", "兇", "大兇", "不如意", "幹你娘", "財運", "如意", "開心", "順利", "破產","努力點" };
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // 隨機洗牌開始
            for (int i = 0; i < names.Length; i++)
            {
                // 先將目前位置中的元素複製一份（為了交換用）
                string temp = names[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = rnd.Next(0, names.Length);
                names[i] = names[r];

                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                names[r] = temp;
                end.Text = names[i].ToString();
            }
        }
    }
}
