using System.Drawing;
using System.Windows.Forms;

namespace PensionLottery
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // results : 각 자리 별 시행 결과
        // indexes : 각 자리 별 최고 숫자 인덱스
        public void setData(int[][] results, int[] indexes)
        {
            setMaxValue(indexes);
            setDataTable(results, indexes);
        }

        private void setDataTable(int[][] results, int[] indexes)
        {
            // 시행 결과
            Label[] firstLabels = { first0, first1, first2, first3, first4, first5, first6, first7, first8, first9, firstTotal };
            Label[] secondLabels = { second0, second1, second2, second3, second4, second5, second6, second7, second8, second9, secondTotal };
            Label[] thirdLabels = { third0, third1, third2, third3, third4, third5, third6, third7, third8, third9, thirdTotal };
            Label[] fourthLabels = { fourth0, fourth1, fourth2, fourth3, fourth4, fourth5, fourth6, fourth7, fourth8, fourth9, fourthTotal };
            Label[] fifthLabels = { fifth0, fifth1, fifth2, fifth3, fifth4, fifth5, fifth6, fifth7, fifth8, fifth9, fifthTotal };
            Label[] sixthLabels = { sixth0, sixth1, sixth2, sixth3, sixth4, sixth5, sixth6, sixth7, sixth8, sixth9, sixthTotal };

            int firt = 0, sect = 0, thit = 0, fout = 0, fift = 0, sixt = 0;
            for (int i = 0; i < results[0].Length; i++)
            {
                firstLabels[i].Text = results[0][i].ToString();
                firt += results[0][i];

                secondLabels[i].Text = results[1][i].ToString();
                sect += results[1][i];

                thirdLabels[i].Text = results[2][i].ToString();
                thit += results[2][i];

                fourthLabels[i].Text = results[3][i].ToString();
                fout += results[3][i];

                fifthLabels[i].Text = results[4][i].ToString();
                fift += results[4][i];

                sixthLabels[i].Text = results[5][i].ToString();
                sixt += results[5][i];
            }
            firstLabels[10].Text = firt + "";
            secondLabels[10].Text = sect + "";
            thirdLabels[10].Text = thit + "";
            fourthLabels[10].Text = fout + "";
            fifthLabels[10].Text = fift + "";
            sixthLabels[10].Text = sixt + "";

            firstLabels[indexes[0]].ForeColor = Color.Red;
            firstLabels[indexes[0]].Font = new Font(this.Font, FontStyle.Bold);
            secondLabels[indexes[1]].ForeColor = Color.Red;
            secondLabels[indexes[1]].Font = new Font(this.Font, FontStyle.Bold);
            thirdLabels[indexes[2]].ForeColor = Color.Red;
            thirdLabels[indexes[2]].Font = new Font(this.Font, FontStyle.Bold);
            fourthLabels[indexes[3]].ForeColor = Color.Red;
            fourthLabels[indexes[3]].Font = new Font(this.Font, FontStyle.Bold);
            fifthLabels[indexes[4]].ForeColor = Color.Red;
            fifthLabels[indexes[4]].Font = new Font(this.Font, FontStyle.Bold);
            sixthLabels[indexes[5]].ForeColor = Color.Red;
            sixthLabels[indexes[5]].Font = new Font(this.Font, FontStyle.Bold);
        }

        // 추첨된 번호로 이미지 표시
        private void setMaxValue(int[] indexes)
        {
            Bitmap[] first = { Properties.Resources._1st_0, Properties.Resources._1st_1, Properties.Resources._1st_2,
                Properties.Resources._1st_3, Properties.Resources._1st_4, Properties.Resources._1st_5,
                Properties.Resources._1st_6, Properties.Resources._1st_7, Properties.Resources._1st_8, Properties.Resources._1st_9};
            Bitmap[] second = { Properties.Resources._2nd_0, Properties.Resources._2nd_1, Properties.Resources._2nd_2,
                Properties.Resources._2nd_3, Properties.Resources._2nd_4, Properties.Resources._2nd_5,
                Properties.Resources._2nd_6, Properties.Resources._2nd_7, Properties.Resources._2nd_8, Properties.Resources._2nd_9};
            Bitmap[] third = { Properties.Resources._3rd_0, Properties.Resources._3rd_1, Properties.Resources._3rd_2,
                Properties.Resources._3rd_3, Properties.Resources._3rd_4, Properties.Resources._3rd_5,
                Properties.Resources._3rd_6, Properties.Resources._3rd_7, Properties.Resources._3rd_8, Properties.Resources._3rd_9};
            Bitmap[] fourth = { Properties.Resources._4th_0, Properties.Resources._4th_1, Properties.Resources._4th_2,
                Properties.Resources._4th_3, Properties.Resources._4th_4, Properties.Resources._4th_5,
                Properties.Resources._4th_6, Properties.Resources._4th_7, Properties.Resources._4th_8, Properties.Resources._4th_9};
            Bitmap[] fifth = { Properties.Resources._5th_0, Properties.Resources._5th_1, Properties.Resources._5th_2,
                Properties.Resources._5th_3, Properties.Resources._5th_4, Properties.Resources._5th_5,
                Properties.Resources._5th_6, Properties.Resources._5th_7, Properties.Resources._5th_8, Properties.Resources._5th_9};
            Bitmap[] sixth = { Properties.Resources._6th_0, Properties.Resources._6th_1, Properties.Resources._6th_2,
                Properties.Resources._6th_3, Properties.Resources._6th_4, Properties.Resources._6th_5,
                Properties.Resources._6th_6, Properties.Resources._6th_7, Properties.Resources._6th_8, Properties.Resources._6th_9};

            firstBox.Image = first[indexes[0]];
            secondBox.Image = second[indexes[1]];
            thirdBox.Image = third[indexes[2]];
            fourthBox.Image = fourth[indexes[3]];
            fifthBox.Image = fifth[indexes[4]];
            sixthBox.Image = sixth[indexes[5]];
        }

        // 글자 스타일 리셋
        public void resetFontStyle()
        {
            // 시행 결과
            Label[] firstLabels = { first0, first1, first2, first3, first4, first5, first6, first7, first8, first9, firstTotal };
            Label[] secondLabels = { second0, second1, second2, second3, second4, second5, second6, second7, second8, second9, secondTotal };
            Label[] thirdLabels = { third0, third1, third2, third3, third4, third5, third6, third7, third8, third9, thirdTotal };
            Label[] fourthLabels = { fourth0, fourth1, fourth2, fourth3, fourth4, fourth5, fourth6, fourth7, fourth8, fourth9, fourthTotal };
            Label[] fifthLabels = { fifth0, fifth1, fifth2, fifth3, fifth4, fifth5, fifth6, fifth7, fifth8, fifth9, fifthTotal };
            Label[] sixthLabels = { sixth0, sixth1, sixth2, sixth3, sixth4, sixth5, sixth6, sixth7, sixth8, sixth9, sixthTotal };

            for (int i = 0; i < 10; i++)
            {
                firstLabels[i].ForeColor = Color.Black;
                firstLabels[i].Font = new Font(this.Font, FontStyle.Regular);
                secondLabels[i].ForeColor = Color.Black;
                secondLabels[i].Font = new Font(this.Font, FontStyle.Regular);
                thirdLabels[i].ForeColor = Color.Black;
                thirdLabels[i].Font = new Font(this.Font, FontStyle.Regular);
                fourthLabels[i].ForeColor = Color.Black;
                fourthLabels[i].Font = new Font(this.Font, FontStyle.Regular);
                fifthLabels[i].ForeColor = Color.Black;
                fifthLabels[i].Font = new Font(this.Font, FontStyle.Regular);
                sixthLabels[i].ForeColor = Color.Black;
                sixthLabels[i].Font = new Font(this.Font, FontStyle.Regular);
            }
        }
    }
}
