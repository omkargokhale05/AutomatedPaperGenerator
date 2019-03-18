using System.Data;
using System.Data.SqlClient;

namespace Project.DAL
{
    public static class DbProcess
    {
        public static void ExamPapersInsert(int personelId, string title, byte[] paper)
        {
            string sql = string.Format(@"INSERT INTO ExamPapers (PersonelId, PaperName, PaperValue) VALUES ({0},'{1}',@paper)", personelId, title);
            SqlParameter p1 = new SqlParameter("paper", paper);
            NativeSqlDb.ExecuteNonQuery(sql, p1);
        }

        public static DataTable ExamPapers(int personelId)
        {
            string sql = string.Format("SELECT Id, PaperName, PaperValue FROM ExamPapers Where PersonelId = {0}", personelId);
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static DataTable GetQuestion(int personelId, int courseId, int rnd) //alter
        {
            string sql = string.Format(@"SELECT {2} Q.Id, Q.ChapterId, Q.QuestionTypeId,Convert(bit,1) Ch, C.ChapterName, T.Name TypeName, Q.Name 
                                            FROM Question Q
                                            Left Join QuestionType T On Q.QuestionTypeId = T.Id
                                            Left Join Chapters C On Q.ChapterId = C.Id
                                            Where Q.IsActive = 1 and 
                                            Q.ChapterId in (
                                            Select Id From Chapters Where CourseId In (
                                            Select CourseId From PersonelsCourses 
                                            Where PersonelId = {0} ) And CourseId = {1}) 
                                            ORDER BY NEWID()", personelId, courseId, (rnd > 0) ? "Top " + rnd : "");
            DataTable dt = NativeSqlDb.ExecuteReader(sql);
            dt.Columns["Ch"].ReadOnly = false;
            return dt;
        }

        //public static DataTable GetQuestion3(int personelId, int courseId,int chapterId,int typeId) //alter
        //{
        //    string sql = string.Format(@"SELECT Q.Id, Q.Name, C.ChapterName, T.Name TypeName  
        //                                    FROM Question Q
        //                                    Left Join QuestionType T On Q.QuestionTypeId = T.Id
        //                                    Left Join Chapters C On Q.ChapterId = C.Id
        //                                    Where Q.IsActive = 1 and 
        //                                    Q.ChapterId in (
        //                                    Select Id From Chapters Where CourseId In (
        //                                    Select CourseId From PersonelsCourses 
        //                                    Where PersonelId = {0} ) And CourseId = {1}) And Q.ChapterId = {3} And Q.QuestionTypeId = {4}
        //                                    ORDER BY NEWID()", personelId, courseId, chapterId, typeId);
        //    DataTable dt = NativeSqlDb.ExecuteReader(sql);
        //  //  dt.Columns["Ch"].ReadOnly = true;
        //    return dt;
        //}


        public static DataTable GetQuestion2(int personelId, DataTable dt2) //prepare
        {
            DataTable dt = null;
            foreach (DataRow r in dt2.Rows)
            {
                string sql = string.Format(@"SELECT {2} Q.Id, Q.ChapterId, Q.QuestionTypeId,Convert(bit,1) Ch, C.ChapterName, T.Name TypeName, Q.Name 
                                            FROM Question Q
                                            Left Join QuestionType T On Q.QuestionTypeId = T.Id
                                            Left Join Chapters C On Q.ChapterId = C.Id
                                            Where Q.IsActive = 1 and 
                                            Q.ChapterId in (
                                            Select Id From Chapters Where CourseId In (
                                            Select CourseId From PersonelsCourses 
                                            Where PersonelId = {0} ) And CourseId = {1}) And Q.ChapterId = {3} And Q.QuestionTypeId = {4}
                                            ORDER BY NEWID()", personelId, r["CourseId"], (int.Parse(r["QuestionsCount"].ToString()) > 0) ? "Top " + r["QuestionsCount"] : "", r["ChapterId"], r["Type"]);
                DataTable temp = NativeSqlDb.ExecuteReader(sql);
                if (dt == null)
                    dt = temp;
                else
                    foreach (DataRow dr in temp.Rows)
                    {
                        dt.Rows.Add(dr.ItemArray);
                    }
            }
            dt.Columns["Ch"].ReadOnly = false;
            return dt;
        }

       

        public static DataTable ShowAnswer()
        {
            string sql = @"SELECT Id, QuestionId, Name, IsCorrect
                            FROM Answer
                            WHERE (QuestionId IN
                            (SELECT Id FROM Question))";
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static DataTable GetSemesters()
        {
            string sql = "SELECT id ,semester FROM semster";
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static DataTable GetPersonelsWithFullName()
        {
            string sql = "SELECT id ,name +' ' + surname FullName From personnel";
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static DataTable GetDepartments()
        {
            string sql = "SELECT DepID,Department FROM DEPARTMENTS Order by Department";
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static DataTable GetCoursesWithDeptId(int cId)
        {
            string sql = string.Format("SELECT courseid, [description] + ' ( ' +course +' )' course FROM COURSES Where DepartmentId = {0}", cId);
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static DataTable PersonelsCoursesList(int pId)
        {
            string sql = string.Format(@"SELECT P.Id,S.semester,C.course,C.description
                                        FROM PersonelsCourses P
                                        Left Join semster S On P.SemesterId = S.id
                                        Left Join Courses C On P.CourseId = C.courseid 
                                        Where PersonelId = {0}", pId);
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static void PersonelCoursesInsert(int semesterId, int personelId, int courseId)
        {
            string sql = string.Format(@"INSERT INTO PersonelsCourses (SemesterId, PersonelId, CourseId)
                                        VALUES({0},{1},{2})", semesterId, personelId, courseId);
            NativeSqlDb.ExecuteNonQuery(sql);
        }

        public static void PersonelCoursesUpdate(int id, int semesterId, int courseId)
        {
            string sql = string.Format(@"UPDATE PersonelsCourses SET SemesterId = {0} ,CourseId = {1} WHERE Id = {2}", semesterId, courseId, id);
            NativeSqlDb.ExecuteNonQuery(sql);
        }

       


        public static void PersonelCoursesDelete(int id)
        {
            string sql = string.Format("Delete PersonelsCourses Where Id = {0}", id);
            NativeSqlDb.ExecuteNonQuery(sql);
        }


        public static DataTable ChapterList(int courseId)
        {
            string sql = string.Format("SELECT Id, ChapterNo, ChapterName FROM Chapters Where CourseId = {0}", courseId);
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static void ChapterInsert(int courseId, int chapterNo, string chapterName)
        {
            string sql = string.Format("INSERT INTO Chapters (CourseId, ChapterNo, ChapterName) VALUES ({0},{1},'{2}')", courseId, chapterNo, chapterName);
            NativeSqlDb.ExecuteNonQuery(sql);
        }

        public static void ChapterDelete(int id)
        {
            string sql = string.Format("Delete Chapters Where Id = {0}", id);
            NativeSqlDb.ExecuteNonQuery(sql);
        }


        public static void ExamPaperss(int id)
        {
            string sql = string.Format("Delete ExamPapers Where Id = {0}", id);
            NativeSqlDb.ExecuteNonQuery(sql);
        }


        public static DataTable PersonelCourseList1(int personelId, int semesterId)
        {
            string sql = string.Format(@"SELECT CourseId, course
                                            FROM PersonelsCourses P
                                            Left Join COURSES C On P.CourseId = C.courseid
                                            Where PersonelId = {0} and SemesterId = {1}
                                            Order by course", personelId, semesterId);
            return NativeSqlDb.ExecuteReader(sql);
        }

        public static int QuestionsInsert(int chapterId, int questionTypeId, string name)
        {
            string sql = string.Format(@"INSERT INTO Question (ChapterId, QuestionTypeId, Name) VALUES ({0},{1},'{2}') 
                                        Select @@IDENTITY", chapterId, questionTypeId, name);
            int i = 0;
            object o = NativeSqlDb.ExecuteScalar(sql);
            i = int.Parse(o.ToString());
            return i;
        }

        public static void AnswerInser(int questionId, string name, bool isCorrect)
        {
            string sql = string.Format("INSERT INTO Answer (QuestionId, Name, IsCorrect) VALUES ({0},'{1}',{2})", questionId, name, (isCorrect) ? 1 : 0);
            NativeSqlDb.ExecuteNonQuery(sql);
        }

        public static object[] chapterNo { get; set; }
    }
}
