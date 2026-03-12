using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatchButton
{
    public partial class ground : Form
    {
        private readonly Random _rd = new Random();

        public ground()
        {
            InitializeComponent();
        }

        private void RunningButton_MouseEnter(object sender, EventArgs e)
        {
           
            // 1. 버튼이 폼의 클라이언트 영역을 벗어나지 않도록 버튼 크기만큼 뺀 영역 내에서만 이동
            int maxX = Math.Max(0, this.ClientSize.Width - RunningButton.Width);
            int maxY = Math.Max(0, this.ClientSize.Height - RunningButton.Height);

            // 2. 랜덤 좌표 추출 (Next의 상한은 exclusive이므로 max+1 사용)
            int nextX = _rd.Next(0, maxX + 1);
            int nextY = _rd.Next(0, maxY + 1);

            // 3. 위치 할당
            RunningButton.Location = new Point(nextX, nextY);

            // 4. 시각적 피드백
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
