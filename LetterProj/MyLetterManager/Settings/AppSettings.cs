﻿//using Semaphore.Infrastructure.WorkWithFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphore.Infrastructure.Settings
{
    public static class AppSettings
    {
        //static string _name;
        // public static string Name { get {return _name;} set { _name = value;}}
        // static string _pathToSynchronizerFolder = @"s:\common\fil_dv\Semaphore\synchronizer";
        //public static string PathToSynchronizerFolder { get { return _pathToSynchronizerFolder; } set { _pathToSynchronizerFolder = value; } }


        //static string _pathToSynchronizerFile = @"s:\common\fil_dv\Semaphore\synchronizer\1.txt";
        // public static string PathToSynchronizerFile { get { return _pathToSynchronizerFile; } set { _pathToSynchronizerFile = value; } }

        //static string _pathToData = @"..\\..\\settings\\data.txt";
        //public static string PathToData { get { return _pathToData; } set { _pathToData = value; } }

        //static string _dbConnectionString = "User ID=import_user;password=sT7hk9Lm;Data Source=CD_WORK";


        static string _dbConnectionString = "User ID=report;password=report;Data Source=CD_WORK";
        public static string DbConnectionString { get { return _dbConnectionString; }}

        //static string _pathToXls = @"..\..\xls\priority.xls";
        static string _pathToXls = @"report.xls";
        public static string PathToXls { get { return _pathToXls; } set { _pathToXls = value; } }

        static string _pathToPriorityLog = @"..\\..\\log\\log_priority.txt";
        public static string PathToPriorityLog { get { return _pathToPriorityLog; } set { _pathToPriorityLog = value; } }

        static string _pathToLetterLog = @"..\\..\\log\\log_letter.txt";
        public static string PathToLetterLog { get { return _pathToLetterLog; } set { _pathToLetterLog = value; } }
    }
}
