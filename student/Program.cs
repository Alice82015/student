﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            // 學生個人資料陣列
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163 };
            string[] sns = { "A106082026", "A106082016", "A106082062", "A106082054", "A104082006", "A106082029", "A106082046", "A106082030", "A106082022", "A106082034", "A103082022", "A106082020", "A106082011", "A106082024", "A105082201", "106082010", "A106082028", "a106082056", "a106082043", "A106082006", "A106082051", "A106082032", "a106082058", "A106082035", "a106082017", "A104082036", "A106082009", "a106082007", "A106082052", "A106082008", "A106082063", "A106082038", "A106082025", "A106082057", "A106082013", "A106082027", "A106082048", "a106082036", "A106082059", "a106082045", "A106082012", "A106082037", "A106082021", "A106082031", "A106082061", "A106082042", "A106082023", "A106082040", "A106082001", "a106082002", "A106082014", "A106082041", "A106082049", "A106082015", "A106082044", "A106082047", "A106082018", "A106082005", "A106082050", "a106082055", "A106082039", "A104082013", "A106082029", "", "A104040024", "A106082047" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍" };
            string[] BloodType = { "O","其他","O","O","A","O","A","A","O","O","A","O","A","B","O","O","A","其他","O","O","A","","B","O","","O","B","O","B","B","B","O","O","AB","O","B","A","O","O","","O","A","","O","O","A","O","O","其他","B","O","O","O","A","AB","A","O","B","AB","","O","O","O","","O","A"};
            string[] Gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女" };

            // 請使用者輸入學號
            Console.WriteLine("請輸入學號！");
            string sn = Console.ReadLine();
            int personN = -1;

            // 找出該學號人的資料
            for (int i=0; i<sns.Length;i++)
            {
                if(sn == sns[i])
                {
                    personN = i;
                }
            }

            // 印出資料
            Console.WriteLine("個人資訊 - 姓名:" + names[personN] + "  性別:" + Gender[personN] + "  血型:" + BloodType[personN] + "  身高:" + heights[personN] + "  星座:" + zodiac[personN]);
            
            // 暫停螢幕
            Console.ReadLine();

        }
       }
    
}
