using System.ComponentModel;
using System.Threading.Tasks;

namespace Section16_비동기연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void Dosomthing()
        {
            //시간이 소요되는 작업
        }

        private async Task DosomthingReturn()
        {
            //Task를 직접 구현하는 방법
            //시간이 소요되는 작업
            await Task.Run(()=> Dosomthing());        
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Dosomthing());

            await DosomthingReturn();
        }
    }
}
