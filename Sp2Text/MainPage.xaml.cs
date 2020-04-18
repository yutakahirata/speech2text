using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sp2Text
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //音声認識の終了したメッセージを受け取る
            MessagingCenter.Subscribe<Object, string>(this, "EndOfVoice", EndOfVoice);
        }
        /// <summary>
        /// ボタンがクリックされたとき
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        void BtnClick(object s, EventArgs e)
        {
            // 音声開始コマンドをMainActivityに送信
            MessagingCenter.Send<Object, string>(this, "StartVoice", "StartVoice");
        }
        /// <summary>
        /// 音声認識の終了
        /// </summary>
        /// <param name="o"></param>
        /// <param name="arg"></param>
        void EndOfVoice(object o, string arg)
        {
            Lb.Text = arg;
        }
    }
}
