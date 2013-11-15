using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackExchange.Profiling;
using System.Text;
using System.Threading;

namespace Sample.WebForms
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var profiler = MiniProfiler.Current;

            //using (mp.Step("Page_Load"))
            //{
            //    System.Threading.Thread.Sleep(40);
            //}

            using (profiler.Step("Doing complex stuff"))
            {
                using (profiler.Step("Step A"))
                { // something more interesting here
                    Thread.Sleep(100);
                }
                using (profiler.Step("Step B"))
                { // and here
                    Thread.Sleep(250);
                }

                using (profiler.Step("GenerateStringByConcat"))
                {
                    GenerateStringByConcat();
                }

                using (profiler.Step("GenerateStringByBuilder"))
                {
                    GenerateStringByBuilder();
                }
            }
            


        }

        private string GenerateStringByConcat()
        {
            string result = String.Empty;
            int n = 999;
            for (int i = 0; i < n; i++)
            {
                result += i.ToString();
            }

            return result;
        }

        private string GenerateStringByBuilder()
        {

            StringBuilder stringBuilder = new StringBuilder();
            int n = 9999;
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(i);
            }

            return stringBuilder.ToString();
        }
    }
}
