using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_PROG
{
    public partial class Deduction : Form
    {
        public Deduction()
        {
            InitializeComponent();
        }

        private void AnnuityCalculation_Click(object sender, EventArgs e)
        {
            // 국민연금 기준소득월액 조건식 부분
            // 2015.06.26 수정(하한액 : 270,000원, 상한액 : 4,210,000원) 
            // 20160630 수정(하한액 = 28만원, 상한액 = 434만원, 적용기간 = 20160701 ~ 20170630)
            // 20170701 적용 (하한액 = 290000 , 상한액 = 4490000 )
            // 20180701 적용 (하한액 = 300000 , 상한액 = 4680000 )
            // 20190701 적용 (하한액 = 310000 , 상한액 = 4860000 )
            // 20200701 적용 (하한액 = 320000 , 상한액 = 5030000 )

            /*var pay = 0;
            var pay2 = 0;
            var pay3 = 0;
            var total1 = 0;
            var total2 = 0;
            var ctotal = 0;
            var ctotal1 = 0;
            var ctotal2 = 0;

            

            var d = new Date(); //데이트객체
            var yeartxt = d.getFullYear(); //올해
            var montxt = d.getMonth() + 1;//이번달           
            var daytxt = d.getDate();  //날짜
            yeartxt = "" + yeartxt;
            montxt = "" + montxt;
            daytxt = "" + daytxt;
            var lowPriceOld = 310000;
            var lowPriceNew = 320000;
            var lowPrice = 0;
            var topPriceOld = 4860000;
            var topPriceNew = 5030000;
            var topPrice = 0;
            var basedateStr = "20200701";
            if (montxt < 10) montxt = "0" + montxt;

            var sysdateStr = yeartxt + montxt + daytxt;

            if (basedateStr <= sysdateStr)
            {
                lowPrice = lowPriceNew;
                topPrice = topPriceNew;
            }
            else
            {
                lowPrice = lowPriceOld;
                topPrice = topPriceOld;
            }

            if (pay <= lowPrice) pay = lowPrice;
            else if (pay >= topPrice) pay = topPrice;

            if (pay <= lowPrice) pay = lowPrice;
            else if (pay >= topPrice) pay = topPrice;
*/
            
        }

        private void AnnuityInitialization_Click(object sender, EventArgs e)
        {

        }
    }
}
