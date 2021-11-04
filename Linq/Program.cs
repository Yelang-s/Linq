using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Master> masters = new List<Master>()
            {
                new Master{ Id=1,Name="风清扬", Age=26, KongfuName="独孤九剑", Menpai="日月神教", Level=7},
                new Master{ Id=2,Name="慕容龙城", Age=19, KongfuName="斗转星移", Menpai="姑苏慕容氏", Level=9},
                new Master{ Id=3,Name="东方不败", Age=32, KongfuName="葵花宝典", Menpai="无门派", Level=8},
                new Master{ Id=4,Name="慕容博", Age=33, KongfuName="凌波微步", Menpai="逍遥派", Level=6},
                new Master{ Id=5,Name="逍遥子", Age=66, KongfuName="北冥神功", Menpai="逍遥派", Level=9},
                new Master{ Id=6,Name="萧峰", Age=43, KongfuName="降龙十八掌", Menpai="丐帮", Level=8},
                new Master{ Id=7,Name="黄裳", Age=34, KongfuName="九阴真经", Menpai="未知", Level=9},
                new Master{ Id=8,Name="天山童姥", Age=100, KongfuName="八荒六合唯我独尊功", Menpai="灵鹫宫", Level=10},
                new Master{ Id=9,Name="段誉", Age=23, KongfuName="六脉神剑", Menpai="大理段氏", Level=9},
                new Master{ Id=10,Name="段誉老爸", Age=56, KongfuName="六脉神剑", Menpai="大理段氏", Level=10}
            };
            List<KongfuBook> kongfuBooks = new List<KongfuBook>()
            {
                new KongfuBook{Id=1, Name="独孤九剑", Power=1, Detail="独孤求败号称剑魔，自创独孤九剑。他四十岁之后，草木竹石均可为剑，渐渐进入了无剑胜有剑的境界。他凭借独孤九剑打遍天下无敌手，欲求一败不可得，郁郁而终。独孤九剑分为九式：总诀式、破剑式、破刀式、破枪式、破鞭式、破索式、破掌式、破箭式、破气式。"},
                new KongfuBook{Id=2, Name="斗转星移", Power=2, Detail="姑苏慕容家的独门绝技。对手的武功越是高强，死法越是巧妙。与后世张无忌的乾坤大挪移有异曲同工之处。姑苏慕容氏正是由于这门神功，江湖人称“以彼之道，还之彼身。"},
                new KongfuBook{Id=3, Name="葵花宝典", Power=3, Detail="本门武功的作者是一位前朝太监。东方不败仅凭《葵花宝典》的残本，就成为当世第一高手。《辟邪剑谱》是《葵花宝典》残本的残本。本秘籍威力巨大，只有一个缺点，必须挥刀自宫才行。"},
                new KongfuBook{Id=4, Name="凌波微步", Power=4, Detail="逍遥派绝学，双脚踩阴阳，走路暗八卦。这门轻功是从易经的八八六十四卦中演变过来的，萧峰曾对段誉这门武功非常的欣赏。神行百变与凌波微步有类似的地方。"},
                new KongfuBook{Id=5, Name="北冥神功", Power=5, Detail="取自“百川汇海，大海之水以容百川而得”，本门武功主要是吸取他人的内力，占为己有。很多武林中人，只听过化功大法，没听过北冥神功。化功大法与吸星大法都是北冥神功的残本。学会这门武功，轻松成为当世第一的内功高手。"},
                new KongfuBook{Id=6, Name="降龙十八掌", Power=6, Detail="本门武功是一门外功，走的是纯阳至刚的路子。本掌法练到高深境界，阳极反阴，刚柔共济。降龙十八掌是天下第一掌法。"},
                new KongfuBook{Id=7, Name="九阴真经", Power=7, Detail="本秘籍包罗万象，内功外功、轻功掌法、刀枪剑棍、疗伤点穴，应有尽有，无所不包。难怪武林中人为了它，宁愿争斗个头破血流了。"},
                new KongfuBook{Id=8, Name="八荒六合唯我独尊功", Power=8, Detail="这门神功金庸给它起过三个名字：第一版，天上地下唯我独尊功。第二版，八荒六合唯我独尊功。第三版，天长地久不老长春功。不但威力奇大，而且能够美容养颜。"},
                new KongfuBook{Id=9, Name="六脉神剑", Power=9, Detail="大理段氏的独门武学。这门武功以一阳指为根基，利用深厚的内力，从手指经脉激发无形剑气，杀敌于无形。四品以上等级的一阳指，方能修行。想学好这门武功，除了会一阳指以外，还需要掌握北冥神功才行。"},
                new KongfuBook{Id=10, Name="太玄经", Power=10, Detail="“谁能书阁下，白首太玄经。”侠客岛有二十四间石洞，里面记载着太玄经的功法。少林方丈，武当掌门，进士翰林，无数武林豪杰穷其一生，头发白了，也参不透太玄经的秘密，却又不愿意离开。"}
            };

            // 基础
            //var res = from m in masters where m.Level > 8 select m;
            //var res = masters.Where(m => m.Level > 8);

            //var res = from m in masters where m.Level > 8 && m.Age > 30 select m;
            //var res = masters.Where(m=>m.Level>8 && m.Age>30);

            // 排序
            //var res = from m in masters where m.Level > 8 orderby m.Level select m;
            //var res = masters.Where(m => m.Level > 8).OrderBy(m => m.Level);


            //var res = from m in masters where m.Level > 8 orderby m.Level,m.Age descending select m;
            //var res = masters.Where(m => m.Level > 8).OrderByDescending(m => m.Level).ThenByDescending(m => m.Age);

            // 联合查询
            //var res = from m in masters from b in kongfuBooks where m.KongfuName == b.Name select new { master = m, book = b };
            //var res = from m in masters join b in kongfuBooks on m.KongfuName equals b.Name select new { master = m, book = b };
            //var res = masters.SelectMany(m => kongfuBooks, (m, b) => new { master = m, kongfu = b }).Where(x => x.master.KongfuName == x.kongfu.Name);

            // 分组查询
            //var res = from b in kongfuBooks join m in masters on b.Name equals m.KongfuName into g orderby g.Count() select new { kongfu = b.Name, count = g.Count() };

            // groupby
            //var res = from m in masters group m by m.Menpai into g select new { mepai = g.Key, count = g.Count() };
         
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
