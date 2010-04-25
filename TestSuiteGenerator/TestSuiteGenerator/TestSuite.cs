using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TestSuiteGenerator
{
    class TestSuiteDB
    {
        static Table[] tables;
        static Message[] msgs;
        static Query[] setupQueries;
        static Query[] cleanupQueries;
        static StaticTest scheck;
        static QueryTestCase[] queryTests;
        static PLTestCase[] plTests;

        static int tabCount = 0;
        static int queryTestCount = 0;
        static int plTestCount = 0;

        public static void saveTable(Table table)
        {
            if (TestSuiteDB.tables == null) TestSuiteDB.tables = new Table[10];
            TestSuiteDB.tables[tabCount] = table;
            TestSuiteDB.tabCount++;
        }

        public static void saveQueryTestCase(QueryTestCase qtc)
        {
            if (queryTests == null) queryTests = new QueryTestCase[10];
            queryTests[queryTestCount] = qtc;
            queryTestCount++;
        }
        public static void savePLTestCase(PLTestCase ptc)
        {
            if (plTests == null) plTests = new PLTestCase[10];
            plTests[plTestCount] = ptc;
            plTestCount++;
        }
        public static void saveCleanupQueries(Query[] queries)
        {
            TestSuiteDB.cleanupQueries = queries;
        }

        public static void saveMessages(Message[] msgs)
        {
            TestSuiteDB.msgs = msgs;
        }

        public static void saveSetupQueries(Query []queries)
        {
            TestSuiteDB.setupQueries = queries;
        }

        public static void saveStaticTest(StaticTest chk)
        {
            TestSuiteDB.scheck = chk;
        }
        public static Table[] getTables()
        {
            return TestSuiteDB.tables;
        }

        public static PLTestCase[] getPLTestCases()
        {
            return plTests;
        }

        public static QueryTestCase[] getQueryTestCases()
        {
            return queryTests;
        }

        public static void GenerateTestSuite(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            
            string str = "<testsuite maxscores=\"30\">\n";
            str += "<tablecheck>\n";
            if (tables != null)
            {
                foreach (Table t in tables)
                {
                    if (t == null) continue;
                    str += t.ToString();
                }
            }
            str += "</tablecheck>\n";
            sw.Write(str);
            str = "";
            if (scheck != null)
            {
                str += scheck.ToString();
            }
            str += "<setup>\n";
            if (setupQueries != null)
            {
                foreach (Query q in setupQueries)
                {
                    if (q == null) continue;
                    str += q.ToString();
                }
            }
            str += "</setup>\n";
            sw.Write(str);
            str = "";
            str += "<dbmsoutputmessages>\n";
            if (msgs != null)
            {
                foreach (Message msg in msgs)
                {
                    if (msg == null) continue;
                    str += msg.ToString();
                }
            }
            sw.Write(str);
            str = "";
            str += "</dbmsoutputmessages>\n";
            if (queryTests != null)
            {
                foreach (QueryTestCase qtc in queryTests)
                {
                    if(qtc == null) continue;
                    str += qtc.ToString();
                }
            }
            sw.Write(str);
            str = "";
            if (plTests != null)
            {
                foreach (PLTestCase ptc in plTests)
                {
                    if (ptc == null) continue;
                    str += ptc.ToString();
                }
            }
            sw.Write(str);
            str = "";
            str += "<cleanup>\n";
            if (cleanupQueries != null)
            {
                foreach (Query q in cleanupQueries)
                {
                    if (q == null) continue;
                    str += q.ToString();
                }
            }
            str += "</cleanup>\n";
            str += "</testsuite>";
            sw.Write(str);
            str = "";
            sw.Close();
            //Console.WriteLine(str);
        }
    }
}
