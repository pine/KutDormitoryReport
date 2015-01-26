using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotClub.DormitoryReport
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var data = new DormitoryReportData();
            data.Name = "宮永 咲";
            
            data.RoomNo = "A150";
            data.PhoneNumber = "090-9999-9999";
            data.LeaderName = "竹井 久";
            data.LeaderPhoneNumber = "090-0000-0000";
            data.Reason = "麻雀部の活動のため";

            var form = DormitoryReport.CreateWindow();

            form.Show(data);
            Application.Run(form);
        }
    }
}
