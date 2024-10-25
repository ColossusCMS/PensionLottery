using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PensionLottery
{
    public partial class Form2 : Form
    {
        Form3 form3;
        Random random = new Random();

        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        public Form2(Form3 _form3)
        {
            InitializeComponent();
            form3 = _form3;
        }

        // 번호 생성 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            int[][] results = new int[6][];
            int[] indexes = new int[6];
            for (int i = 0; i < results.Length; i++)
            {
                int[] result = null;
                result = CastingNumber();
                results[i] = result;

                // 최댓값 인덱스 가져오기
                int index = getMaxValue(results[i]);
                indexes[i] = index;

                // 추첨된 번호로 이미지 표시
                setMaxValue(i, index);

            }

            form3.resetFontStyle();

            // 추첨 이력 데이터 전달
            form3.setData(results, indexes);

            // 디버깅용 결과 출력용
            for (int i = 0; i < results.Length; i++)
            {
                int num = 0;
                Debug.WriteLine("{0} 번째", i);
                for(int j = 0; j < results[i].Length; j++)
                {
                    num += results[i][j];
                    Debug.WriteLine("{0}번째 : {1}, ", j, results[i][j]);
                }
                Debug.WriteLine("총합 : {0}", num);
            }

            MessageBox.Show("번호 추첨 완료", "추첨 완료");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.create_num_clicked;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.create_num_normal;
        }

        // 숫자 1자리 추첨
        /*
         * 1. 랜덤 숫자 뽑음
         * 2. 뽑은 숫자를 인덱스로 해서 배열의 값을 ++
         * 3. 이거 만번 실행
         * 4. 배열에서 가장 값이 높은 숫자 뽑음
         * 4-1. 만약 동률이 있을 경우 1번부터 다시 시작
         * 5. 배열 리턴
         */
        private int[] CastingNumber()
        {
            
            bool repeat = true;
            int[] numberArray = null;
            // 중복 발생 시 다시 진행하기 위해
            while (repeat)
            {
                numberArray = new int[10];    // 0~9번방
                for (int i = 0; i < 10000; i++) // 10000번 시행
                {
                    int num = 0;
                    // 랜덤 숫자 뽑음
                    byte[] data = new byte[4];
                    var rand = System.Security.Cryptography.RandomNumberGenerator.Create();
                    rand.GetBytes(data);
                    num = Math.Abs(BitConverter.ToInt32(data, 0)) % 10;
                    numberArray[num]++;
                }

                // 배열 내 값들을 비교해 중복된 값이 있는지 확인
                for (int i = 0; i < numberArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < numberArray.Length; j++)
                    {
                        if (numberArray[i] == numberArray[j])
                        {
                            repeat = true;
                            Debug.WriteLine("중복발생");
                            break;
                        }
                        else
                        {
                            repeat = false;
                        }

                    }
                }
            }
            return numberArray;
        }

        // 배열 내 최댓값 인덱스 찾기
        private int getMaxValue(int[] intArray)
        {
            int maxValueIndex = 0;
            int maxValue = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (maxValue < intArray[i])
                {
                    maxValue = intArray[i];
                    maxValueIndex = i;
                }
            }
            return maxValueIndex;
        }

        // 추첨된 번호로 이미지 표시
        private void setMaxValue(int index, int data)
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

            switch (index)
            {
                case 0:
                    firstBox.Image = first[data];
                    break;
                case 1:
                    secondBox.Image = second[data];
                    break;
                case 2:
                    thirdBox.Image = third[data];
                    break;
                case 3:
                    fourthBox.Image = fourth[data];
                    break;
                case 4:
                    fifthBox.Image = fifth[data];
                    break;
                case 5:
                    sixthBox.Image = sixth[data];
                    break;
            }
            
        }
    }
}
