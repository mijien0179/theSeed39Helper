using Microsoft.VisualStudio.TestTools.UnitTesting;
using theSeed39Searcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSeed39Searcher.Tests
{
    [TestClass()]
    public class FindQueryTests
    {
        Form1 frm = new Form1();

        [TestMethod("")]
        public void Form1Test()
        {
            string[] containsCorrectionList=
            {
                "오르", "약초", "스탄", "쉐인", "카산"
            };

            foreach(string str in containsCorrectionList)
            {
                Assert.IsTrue(ContainsCorrection(str), $"검색: {str} / '{str}' 없음");
            }

            (string, string)[] querySearchCorrection =
            {
                ("오르", "아쿠아아쿠아"),
                ("존재 도시","슬리피우드"),
                ("오르 리움","컨닝시티"),
                ("적 보스","락 스피릿"),
                ("불편해 한답니다.","로웬"),
                ("몽키 매직","슬러그 샷"),
                ("불여우령 스킬","하이퍼 애큐러시"),
                ("분혼 격참 통백권","불여우령"),
                ("상상력 증가","아이언바디"),
                ("퍼펙트 센스","어큐트 센스"),
            };

            foreach((string,string) item in querySearchCorrection)
            {
                var t = QueryAnswerCorrection(item.Item1, item.Item2);
                Assert.IsTrue(t.Item1, $"검사 실패: \'{t.Item2}\'\nquery:{t.Item3}");
            }
        }

        public bool ContainsCorrection(string str)
        {
            return QueryAnswerCorrection(str, str).Item1;
        }

        public (bool, string, string) QueryAnswerCorrection(string query, string find)
        {
            frm.Query = query;
            
            return (frm.selected.Contains(find), frm.selected, query);
        }


    }
}