using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RSys.Sqlite
{
    public class QuestionnaireDatabase
    {
        private static string Location
        {
            get
            {
                return Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().IndexOf("RSys.Api") + 8);
            }
        }

        private static string FileName
        {
            get
            {
                return "Questionnaire.db";
            }
        }

        public static string DataSource()
        {
            return string.Format(@"Data Source={0}\\{1}", Location, FileName);
        }
    }
}
