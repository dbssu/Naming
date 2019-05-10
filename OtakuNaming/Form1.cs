using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtakuNaming
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;
        string MonName;
        string DayName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            if (this.month1.Checked)
            {
                MonName = "달";
            }
            else if (this.month2.Checked)
            {
                MonName = "사랑";
            }
            else if (this.month3.Checked)
            {
                MonName = "하늘";
            }
            else if (this.month4.Checked)
            {
                MonName = "물";
            }
            else if (this.month5.Checked)
            {
                MonName = "꽃";
            }
            else if (this.month6.Checked)
            {
                MonName = "우주";
            }
            else if (this.month7.Checked)
            {
                MonName = "태양";
            }
            else if (this.month8.Checked)
            {
                MonName = "별";
            }
            else if (this.month9.Checked)
            {
                MonName = "숲";
            }
            else if (this.month10.Checked)
            {
                MonName = "그림자";
            }
            else if (this.month11.Checked)
            {
                MonName = "천국";
            }
            else if (this.month12.Checked)
            {
                MonName = "눈";
            }

            if (this.day1.Checked)
            {
                this.DayName = "파편";
            }
            else if (this.day2.Checked)
            {
                this.DayName = "천사";
            }
            else if (this.day3.Checked)
            {
                this.DayName = "눈물";
            }
            else if (this.day4.Checked)
            {
                this.DayName = "증거";
            }
            else if (this.day5.Checked)
            {
                this.DayName = "꿈";
            }
            else if (this.day6.Checked)
            {
                this.DayName = "마음";
            }
            else if (this.day7.Checked)
            {
                this.DayName = "물방울";
            }
            else if (this.day8.Checked)
            {
                this.DayName = "요정";
            }
            else if (this.day9.Checked)
            {
                this.DayName = "음악";
            }
            else if (this.day10.Checked)
            {
                this.DayName = "빛";
            }
            else if (this.day11.Checked)
            {
                this.DayName = "상어";
            }
            else if (this.day12.Checked)
            {
                this.DayName = "결정";
            }
            else if (this.day13.Checked)
            {
                this.DayName = "속삭임";
            }
            else if (this.day14.Checked)
            {
                this.DayName = "신탁";
            }
            else if (this.day15.Checked)
            {
                this.DayName = "주문";
            }
            else if (this.day16.Checked)
            {
                this.DayName = "사기꾼";
            }
            else if (this.day17.Checked)
            {
                this.DayName = "기도";
            }
            else if (this.day18.Checked)
            {
                this.DayName = "고양이";
            }
            else if (this.day19.Checked)
            {
                this.DayName = "안내자";
            }
            else if (this.day20.Checked)
            {
                this.DayName = "파곰";
            }
            else if (this.day21.Checked)
            {
                this.DayName = "보호자";
            }
            else if (this.day22.Checked)
            {
                this.DayName = "마법";
            }
            else if (this.day23.Checked)
            {
                this.DayName = "보물";
            }
            else if (this.day24.Checked)
            {
                this.DayName = "영혼";
            }
            else if (this.day25.Checked)
            {
                this.DayName = "여괴";
            }
            else if (this.day26.Checked)
            {
                this.DayName = "여우";
            }
            else if (this.day27.Checked)
            {
                this.DayName = "늑대";
            }
            else if (this.day28.Checked)
            {
                this.DayName = "날개";
            }
            else if (this.day29.Checked)
            {
                this.DayName = "서눔ㄹ";
            }
            else if (this.day30.Checked)
            {
                this.DayName = "괴도";
            }
            else if (this.day31.Checked)
            {
                this.DayName = "지배자";
            }

            if (this.DayName == null || this.DayName == "")
            {
                MessageBox.Show(
                    "태어난 날짜를 선택해 주세요", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((
                    this.month4.Checked ||
                    this.month6.Checked ||
                    this.month8.Checked ||
                    this.month10.Checked ||
                    this.month12.Checked)
                     &&
                     (this.day31.Checked))
                {
                    MessageBox.Show(
                   "해당 날짜에 태어난사람은 없습니다!", "신탁",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    "당신의 이름은\n["
                    + this.MonName + "의 " + this.DayName
                    + "] 입니다!!", "신탁",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
