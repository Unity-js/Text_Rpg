using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Reflection.Metadata.Ecma335;

namespace TextRpg
{
    internal class Program
    {


        class jobs
        {
            public int level = 01;
            public string name;
            public string job;
            public float atk = 10;
            public float def = 5;
            public float hp = 100;
            public float gold = 1500;

            public int clearcount = 0;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n");

            Console.WriteLine("\n이름을 설정해주세요.\n");
            jobs job = new jobs();
            job.name = Console.ReadLine();

            String[] itempool = new String[7];

            itempool[0] = "수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | ";
            itempool[1] = "무쇠갑옷 | 방어력 + 9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | ";
            itempool[2] = "스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | ";
            itempool[3] = "낡은 검 | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다. | ";
            itempool[4] = "청동 도끼 | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | ";
            itempool[5] = "스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | ";
            itempool[6] = "컴파일 에러 | 공격력 -2147483647 | 빨간 줄을 싫어하는 사람들이 자주 이용하던 무기입니다. | ";

            int[] purchase = { 1000, 2000, 3500, 600, 1500, 2000, 2147483647 };

            bool[] purchaseq = { false, false, false, false, false, false, false };

            bool[] equipq = { false, false, false, false, false, false, false };

            while (true)
            {
                Console.WriteLine("\n직업을 설정해주세요.\n\n1. 전사\n\n2. 마법사");
                int jobnum = int.Parse(Console.ReadLine());

                switch (jobnum)
                {
                    case 1:
                        job.job = "전사";
                        break;

                    case 2:
                        job.job = "마법사";
                        break;

                    default:
                        Console.WriteLine("1 또는 2를 입력해주세요\n");
                        continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n\n1. 상태보기\n\n2. 인벤토리\n\n3. 상점\n\n4. 휴식하기\n\n5. 던전 입장\n\n원하시는 행동을 입력해주세요.");

                int action = int.Parse(Console.ReadLine());

                if (job.clearcount == job.level)
                { 
                    job.level += 1;
                    job.atk += 0.5f;
                    job.def += 1.0f;
                    job.clearcount = 0;
                }

                switch (action)
                {

                    case 1:
                        Console.WriteLine("캐릭터의 현재 정보입니다.\n\n"); // 1번 입력시 상태보기
                        Console.WriteLine("Lv. " + job.level);
                        Console.WriteLine(job.name + " ( " + job.job + " )");
                        Console.WriteLine("공격력 : " + job.atk);
                        Console.WriteLine("방어력 : " + job.def);
                        Console.WriteLine("체 력 : " + job.hp);
                        Console.WriteLine("Gold : " + job.gold + " G");

                        Console.WriteLine("\n0. 나가기");
                        Console.WriteLine("\n원하시는 행동을 입력해주세요.");

                        while (true) // 상태보기 화면 루프용
                        {
                            int intrs = int.Parse(Console.ReadLine());

                            if (intrs == 0) break;

                            else
                            {
                                Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");
                                continue;
                            }

                            break;
                        } // 까지

                        continue;

                    case 2: //인벤토리
                        Console.WriteLine("\n\n인벤토리");
                        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                        Console.WriteLine("\n[아이템 목록]");
                        Console.WriteLine("\n1. 장착 관리");
                        Console.WriteLine("\n0. 나가기");
                        Console.WriteLine("\n원하시는 행동을 입력해주세요.");

                        while (true) // 장착 관리 트리거
                        {
                            int intrs = int.Parse(Console.ReadLine());

                            if (intrs == 1)
                            {
                                while (true)
                                {
                                    if (purchaseq[0] && !equipq[0]) Console.WriteLine($"\n1. {itempool[0]}");
                                    else if (purchaseq[0] && equipq[0]) Console.WriteLine($"\n1. [E]{itempool[0]}");
                                    else Console.WriteLine($"\n1. [미보유] {itempool[0]}");

                                    if (purchaseq[1] && !equipq[1]) Console.WriteLine($"\n2. {itempool[1]}");
                                    else if (purchaseq[1] && equipq[1]) Console.WriteLine($"\n2. [E]{itempool[1]}");
                                    else Console.WriteLine($"\n2. [미보유] {itempool[1]}");

                                    if (purchaseq[2] && !equipq[2]) Console.WriteLine($"\n3. {itempool[2]}");
                                    else if (purchaseq[2] && equipq[2]) Console.WriteLine($"\n3. [E]{itempool[2]}");
                                    else Console.WriteLine($"\n3. [미보유] {itempool[2]}");

                                    if (purchaseq[3] && !equipq[3]) Console.WriteLine($"\n4. {itempool[3]}");
                                    else if (purchaseq[3] && equipq[3]) Console.WriteLine($"\n4. [E]{itempool[3]}");
                                    else Console.WriteLine($"\n4. [미보유] {itempool[3]}");

                                    if (purchaseq[4] && !equipq[4]) Console.WriteLine($"\n5. {itempool[4]}");
                                    else if (purchaseq[4] && equipq[4]) Console.WriteLine($"\n5. [E]{itempool[4]}");
                                    else Console.WriteLine($"\n5. [미보유] {itempool[4]}");

                                    if (purchaseq[5] && !equipq[5]) Console.WriteLine($"\n6. {itempool[5]}");
                                    else if (purchaseq[5] && equipq[5]) Console.WriteLine($"\n6. [E]{itempool[5]}");
                                    else Console.WriteLine($"\n6. [미보유] {itempool[5]}");

                                    if (purchaseq[6] && !equipq[6]) Console.WriteLine($"\n7. {itempool[6]}");
                                    else if (purchaseq[6] && equipq[6]) Console.WriteLine($"\n7. [E]{itempool[6]}");
                                    else Console.WriteLine($"\n7. [미보유] {itempool[6]}");

                                    Console.WriteLine("\n0. 나가기");
                                    Console.WriteLine("\n원하시는 행동을 입력해주세요.");

                                    int intrss = int.Parse(Console.ReadLine());

                                    if (intrss == 1 && purchaseq[0] == true && equipq[0] == false)
                                    {
                                        equipq[0] = true;
                                        job.def += 5;
                                        Console.WriteLine("수련자 갑옷을 장착 했습니다.");
                                        equipq[1] = false;
                                        equipq[2] = false;
                                        continue;
                                    }
                                    else if (intrss == 1 && purchaseq[0] == true && equipq[0] == true)
                                    {
                                        equipq[0] = false;
                                        job.def -= 5;
                                        Console.WriteLine("수련자 갑옷을 장착 해제했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 1 && purchaseq[0] == false && equipq[0] == false)
                                    {
                                        Console.WriteLine("수련자 갑옷을 보유하고 있지 않습니다.");
                                        continue;
                                    }

                                    if (intrss == 2 && purchaseq[1] == true && equipq[1] == false)
                                    {
                                        equipq[1] = true;
                                        job.def += 9;
                                        Console.WriteLine("무쇠갑옷을 장착 했습니다.");
                                        equipq[0] = false;
                                        equipq[2] = false;
                                        continue;
                                    }
                                    else if (intrss == 2 && purchaseq[1] == true && equipq[1] == true)
                                    {
                                        equipq[1] = false;
                                        job.def -= 9;
                                        Console.WriteLine("무쇠갑옷을 장착 해제했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 2 && purchaseq[1] == false && equipq[1] == false)
                                    {
                                        Console.WriteLine("무쇠갑옷을 보유하고 있지 않습니다.");
                                        continue;
                                    }

                                    if (intrss == 3 && purchaseq[2] == true && equipq[2] == false)
                                    {
                                        equipq[2] = true;
                                        job.def += 15;
                                        Console.WriteLine("스파르타의 갑옷을 장착 했습니다.");
                                        equipq[0] = false;
                                        equipq[1] = false;
                                        continue;
                                    }
                                    else if (intrss == 3 && purchaseq[2] == true && equipq[2] == true)
                                    {
                                        equipq[2] = false;
                                        job.def -= 15;
                                        Console.WriteLine("스파르타의 갑옷을 장착 해제했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 3 && purchaseq[2] == false && equipq[2] == false)
                                    {
                                        Console.WriteLine("스파르타의 갑옷을 보유하고 있지 않습니다.");
                                        continue;
                                    }

                                    if (intrss == 4 && purchaseq[3] == true && equipq[3] == false)
                                    {
                                        equipq[3] = true;
                                        job.atk += 2;
                                        Console.WriteLine("낡은 검을 장착 했습니다.");
                                        equipq[4] = false;
                                        equipq[5] = false;
                                        continue;
                                    }
                                    else if (intrss == 4 && purchaseq[3] == true && equipq[3] == true)
                                    {
                                        equipq[3] = false;
                                        job.atk -= 2;
                                        Console.WriteLine("낡은 검을 장착 해제했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 4 && purchaseq[3] == false && equipq[3] == false)
                                    {
                                        Console.WriteLine("낡은 검을 보유하고 있지 않습니다.");
                                        continue;
                                    }

                                    if (intrss == 5 && purchaseq[4] == true && equipq[4] == false)
                                    {
                                        equipq[4] = true;
                                        job.atk += 5;
                                        Console.WriteLine("청동 도끼를 장착 했습니다.");
                                        equipq[3] = false;
                                        equipq[5] = false;
                                        continue;
                                    }
                                    else if (intrss == 5 && purchaseq[4] == true && equipq[4] == true)
                                    {
                                        equipq[4] = false;
                                        job.atk -= 5;
                                        Console.WriteLine("청동 도끼를 장착 해제했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 5 && purchaseq[4] == false && equipq[4] == false)
                                    {
                                        Console.WriteLine("청동 도끼를 보유하고 있지 않습니다.");
                                        continue;
                                    }

                                    if (intrss == 6 && purchaseq[5] == true && equipq[5] == false)
                                    {
                                        equipq[5] = true;
                                        job.atk += 7;
                                        Console.WriteLine("스파르타의 창을 장착 했습니다.");
                                        equipq[3] = false;
                                        equipq[4] = false;
                                        continue;
                                    }
                                    else if (intrss == 6 && purchaseq[5] == true && equipq[5] == true)
                                    {
                                        equipq[5] = false;
                                        job.atk -= 7;
                                        Console.WriteLine("스파르타의 창을 장착 해제했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 6 && purchaseq[5] == false && equipq[5] == false)
                                    {
                                        Console.WriteLine("스파르타의 창을 보유하고 있지 않습니다.");
                                        continue;
                                    }

                                    if (intrss == 7 && purchaseq[6] == true && equipq[6] == false)
                                    {
                                        equipq[6] = true;
                                        job.atk += 2147483647;
                                        Console.WriteLine("컴파일 에러가 발생했습니다.");
                                        continue;
                                    }
                                    else if (intrss == 7 && purchaseq[6] == true && equipq[6] == true)
                                    {
                                        equipq[6] = false;
                                        job.atk -= -2147483647;
                                        Console.WriteLine("에러를 해결했습니다!");
                                        continue;
                                    }
                                    else if (intrss == 7 && purchaseq[6] == false && equipq[6] == false)
                                    {
                                        Console.WriteLine("컴파일 에러를 보유하고 있지 않습니다!");
                                        continue;
                                    }
                                    break;
                                }
                            }

                            else if (intrs == 0) break;

                            else
                            {
                                Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");
                                continue;
                            }

                            break;
                        } // 까지

                        continue;

                    case 3: //상점

                        Console.WriteLine("\n\n상점");
                        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                        Console.WriteLine("\n[보유 골드]");
                        Console.WriteLine(job.gold + " Gold");
                        Console.WriteLine("\n[아이템 목록]\n");

                        if (purchaseq[0] == false)
                        {
                            Console.WriteLine("1. " + itempool[0] + purchase[0] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[0] + " 구매 완료\n");

                        if (purchaseq[1] == false)
                        {
                            Console.WriteLine("2. " + itempool[1] + purchase[1] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[1] + " 구매 완료\n");

                        if (purchaseq[2] == false)
                        {
                            Console.WriteLine("3. " + itempool[2] + purchase[2] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[2] + " 구매 완료\n");

                        if (purchaseq[3] == false)
                        {
                            Console.WriteLine("4. " + itempool[3] + purchase[3] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[3] + " 구매 완료\n");

                        if (purchaseq[4] == false)
                        {
                            Console.WriteLine("5. " + itempool[4] + purchase[4] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[4] + " 구매 완료\n");

                        if (purchaseq[5] == false)
                        {
                            Console.WriteLine("6. " + itempool[5] + purchase[5] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[5] + " 구매 완료\n");

                        if (purchaseq[6] == false)
                        {
                            Console.WriteLine("7. " + itempool[6] + purchase[6] + " Gold\n");
                        }
                        else Console.WriteLine(itempool[6] + " 구매 완료\n");

                        Console.WriteLine("8. 판매\n");
                        Console.WriteLine("0. 나가기");
                        Console.WriteLine("\n원하시는 행동을 입력해주세요.");

                        while (true) // 구매 트리거
                        {
                            int intrs = int.Parse(Console.ReadLine());

                            if (intrs == 1)
                            {
                                if (purchaseq[0] == false)
                                {
                                    if (job.gold < purchase[0])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[0])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 1000;
                                        purchaseq[0] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }
                            else if (intrs == 2)
                            {
                                if (purchaseq[1] == false)
                                {
                                    if (job.gold < purchase[1])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[1])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 2000;
                                        purchaseq[1] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }
                            else if (intrs == 3)
                            {
                                if (purchaseq[2] == false)
                                {
                                    if (job.gold < purchase[2])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[2])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 3500;
                                        purchaseq[2] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }
                            else if (intrs == 4)
                            {
                                if (purchaseq[3] == false)
                                {
                                    if (job.gold < purchase[3])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[3])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 600;
                                        purchaseq[3] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }
                            else if (intrs == 5)
                            {
                                if (purchaseq[4] == false)
                                {
                                    if (job.gold < purchase[4])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[4])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 1500;
                                        purchaseq[4] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }
                            else if (intrs == 6)
                            {
                                if (purchaseq[5] == false)
                                {
                                    if (job.gold < purchase[5])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[5])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 2000;
                                        purchaseq[5] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }
                            else if (intrs == 7)
                            {
                                if (purchaseq[6] == false)
                                {
                                    if (job.gold < purchase[6])
                                    {
                                        Console.WriteLine("Gold 가 부족합니다.");
                                        continue;
                                    }
                                    else if (job.gold >= purchase[6])
                                    {
                                        Console.WriteLine("구매를 완료 했습니다.");
                                        job.gold = job.gold - 2147483647;
                                        purchaseq[6] = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    continue;
                                }
                            }

                            else if (intrs == 0) break;

                            else if (intrs == 8)
                            {
                                Console.WriteLine("보유한 아이템을 85%의 가격으로 판매합니다. 판매할 아이템을 입력하세요.");

                                while (true)
                                {
                                    int intrss = int.Parse(Console.ReadLine());

                                    if (intrss == 1)
                                    {
                                        if (purchaseq[0] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[0] = false;
                                            if (equipq[0]) equipq[0] = false; job.def -= 5;
                                            job.gold += 850;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }

                                    if (intrss == 2)
                                    {
                                        if (purchaseq[1] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[1] = false;
                                            if (equipq[1]) equipq[1] = false; job.def -= 9;
                                            job.gold += 1700;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }

                                    if (intrss == 3)
                                    {
                                        if (purchaseq[2] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[2] = false;
                                            if (equipq[2]) equipq[2] = false; job.def -= 15;
                                            job.gold += 2975;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }

                                    if (intrss == 4)
                                    {
                                        if (purchaseq[3] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[3] = false;
                                            if (equipq[3]) equipq[3] = false; job.atk -= 2;
                                            job.gold += 510;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }

                                    if (intrss == 5)
                                    {
                                        if (purchaseq[4] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[4] = false;
                                            if (equipq[4]) equipq[4] = false; job.atk -= 5;
                                            job.gold += 1275;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }

                                    if (intrss == 6)
                                    {
                                        if (purchaseq[5] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[5] = false;
                                            if (equipq[5]) equipq[5] = false; job.atk -= 7;
                                            job.gold += 1700;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }

                                    if (intrss == 7)
                                    {
                                        if (purchaseq[6] == true)
                                        {
                                            Console.WriteLine("판매를 완료했습니다.");
                                            purchaseq[6] = false;
                                            if (equipq[6]) equipq[6] = false; job.atk -= 2147483647;
                                            job.gold += 1825361099;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("아이템을 보유하고 있지 않습니다.");
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                                continue;
                            }

                            break;

                        } // 까지

                        continue;

                    case 4: //휴식
                        Console.WriteLine("1. 휴식하기\n0. 나가기");
                        Console.WriteLine($"500G를 내면 체력을 회복 할 수 있습니다. (보유 골드 : {job.gold} G) \n");

                        while (true)
                        {
                            int intrs = int.Parse(Console.ReadLine());

                            if (intrs == 1 && job.gold >= 500)
                            {
                                Console.WriteLine("휴식을 취해 체력이 회복 되었습니다!");
                                job.gold -= 500;
                                job.hp = 100;

                                break;
                            }
                            else if (intrs == 1 && job.gold < 500)
                            {
                                Console.WriteLine("소지 골드가 부족합니다.");
                                break;
                            }

                            else break;
                        }

                        continue;

                    case 5: //던전

                        Console.WriteLine("던전입장\r\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n\n");
                        Console.WriteLine("1. 쉬운 던전 | 방어력 5 이상 권장\n");
                        Console.WriteLine("2. 일반 던전 | 방어력 11 이상 권장\n");
                        Console.WriteLine("3. 어려운 던전 | 방어력 17 이상 권장\n");
                        Console.WriteLine("0. 나가기");


                        while (true)
                        {
                            int intrs = int.Parse(Console.ReadLine());

                            Random random = new Random();

                            int failchance = random.Next(1, 11);

                            switch (intrs)
                            {
                                case 0: break;

                                case 1:
                                    if (job.def < 5)
                                    {
                                        if (failchance <= 4)
                                        {
                                            Console.WriteLine("던전 공략에 실패했습니다.");
                                            job.hp /= 2;
                                        }
                                        else
                                        {
                                            Console.WriteLine("던전 클리어\n축하합니다!!\n쉬운 던전을 클리어하였습니다.\n[탐험 결과]\n");
                                            Console.WriteLine($"체력 {job.hp}-> ");

                                            Random random1 = new Random();

                                            int damage = random1.Next(20 + (int)job.def - 5, 36 + (int)job.def - 5);

                                            job.hp -= damage;

                                            Console.WriteLine($"{job.hp}\n");

                                            Console.WriteLine($"Gold {job.gold}-> ");

                                            job.gold += 1000.0f;

                                            Random random2 = new Random();

                                            int bonusgoldrad = (int)job.atk;

                                            float bonusgold = random2.Next(bonusgoldrad, 21);

                                            job.gold += 1000.0f * (bonusgold * 0.01f);

                                            Console.WriteLine($"{job.gold}\n");

                                            job.clearcount += 1;

                                            if (job.hp <= 0.0f)
                                            {
                                                Console.WriteLine($"{job.name}님이 사망하셨습니다.");
                                                Environment.Exit(0);
                                            }

                                            while (true)

                                            {
                                                Console.WriteLine("\n0. 나가기\n원하시는 행동을 입력해주세요.");

                                                int intrss = int.Parse(Console.ReadLine());

                                                if (intrss != 0) Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");

                                                if (intrss == 0) break;
                                            }
                                        }
                                    }
                                    else if (job.def >= 5)
                                    {
                                        Console.WriteLine("던전 클리어\n축하합니다!!\n쉬운 던전을 클리어하였습니다.\n[탐험 결과]\n");
                                        Console.WriteLine($"체력 {job.hp}-> ");

                                        Random random1 = new Random();

                                        int damage = random1.Next(20 + (int)job.def - 5, 36 + (int)job.def - 5);

                                        job.hp -= damage;

                                        Console.WriteLine($"{job.hp}\n");

                                        Console.WriteLine($"Gold {job.gold}-> ");

                                        job.gold += 1000.0f;

                                        Random random2 = new Random();

                                        int bonusgoldrad = (int)job.atk;

                                        float bonusgold = random2.Next(bonusgoldrad, 21);

                                        job.gold += 1000.0f * (bonusgold * 0.01f);

                                        Console.WriteLine($"{job.gold}\n");

                                        job.clearcount += 1;

                                        if (job.hp <= 0.0f)
                                        {
                                            Console.WriteLine($"{job.name}님이 사망하셨습니다.");
                                            Environment.Exit(0);
                                        }

                                        while (true)

                                        {
                                            Console.WriteLine("\n0. 나가기\n 원하시는 행동을 입력해주세요.");

                                            int intrss = int.Parse(Console.ReadLine());

                                            if (intrss != 0) Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");

                                            if (intrss == 0) break;
                                        }

                                    }
                                    break;


                                case 2:
                                    if (job.def < 11)
                                    {
                                        if (failchance <= 4)
                                        {
                                            Console.WriteLine("던전 공략에 실패했습니다.");
                                            job.hp /= 2;
                                        }
                                        else
                                        {
                                            Console.WriteLine("던전 클리어\n축하합니다!!\n일반 던전을 클리어하였습니다.\n[탐험 결과]\n");
                                            Console.WriteLine($"체력 {job.hp}-> ");

                                            Random random1 = new Random();

                                            int damage = random1.Next(20 + (int)job.def - 11, 36 + (int)job.def - 11);

                                            job.hp -= damage;

                                            Console.WriteLine($"{job.hp}\n");

                                            Console.WriteLine($"Gold {job.gold}-> ");

                                            job.gold += 1700.0f;

                                            Random random2 = new Random();

                                            int bonusgoldrad = (int)job.atk;

                                            float bonusgold = random2.Next(bonusgoldrad, 21);

                                            job.gold += 1700.0f * (bonusgold * 0.01f);

                                            Console.WriteLine($"{job.gold}\n");

                                            job.clearcount += 1;

                                            if (job.hp <= 0.0f)
                                            {
                                                Console.WriteLine($"{job.name}님이 사망하셨습니다.");
                                                Environment.Exit(0);
                                            }

                                            while (true)

                                            {
                                                Console.WriteLine("\n0. 나가기\n 원하시는 행동을 입력해주세요.");

                                                int intrss = int.Parse(Console.ReadLine());

                                                if (intrss != 0) Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");

                                                if (intrss == 0) break;
                                            }
                                        }
                                    }
                                    else if (job.def >= 11)
                                    {
                                        Console.WriteLine("던전 클리어\n축하합니다!!\n일반 던전을 클리어하였습니다.\n[탐험 결과]\n");
                                        Console.WriteLine($"체력 {job.hp}-> ");

                                        Random random1 = new Random();

                                        int damage = random1.Next(20 + (int)job.def - 11, 36 + (int)job.def - 11);

                                        job.hp -= damage;

                                        Console.WriteLine($"{job.hp}\n");

                                        Console.WriteLine($"Gold {job.gold}-> ");

                                        job.gold += 1700.0f;

                                        Random random2 = new Random();

                                        int bonusgoldrad = (int)job.atk;

                                        float bonusgold = random2.Next(bonusgoldrad, 21);

                                        job.gold += 1700.0f * (bonusgold * 0.01f);

                                        Console.WriteLine($"{job.gold}\n");

                                        job.clearcount += 1;

                                        if (job.hp <= 0.0f)
                                        {
                                            Console.WriteLine($"{job.name}님이 사망하셨습니다.");
                                            Environment.Exit(0);
                                        }

                                        while (true)

                                        {
                                            Console.WriteLine("\n0. 나가기\n 원하시는 행동을 입력해주세요.");

                                            int intrss = int.Parse(Console.ReadLine());

                                            if (intrss != 0) Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");

                                            if (intrss == 0) break;
                                        }

                                    }
                                    break;

                                case 3:
                                    if (job.def < 17)
                                    {
                                        if (failchance <= 4)
                                        {
                                            Console.WriteLine("던전 공략에 실패했습니다.");
                                            job.hp /= 2;
                                        }
                                        else
                                        {
                                            Console.WriteLine("던전 클리어\n축하합니다!!\n어려운 던전을 클리어하였습니다.\n[탐험 결과]\n");
                                            Console.WriteLine($"체력 {job.hp}-> ");

                                            Random random1 = new Random();

                                            int damage = random1.Next(20 + (int)job.def - 17, 36 + (int)job.def - 17);

                                            job.hp -= damage;

                                            Console.WriteLine($"{job.hp}\n");

                                            Console.WriteLine($"Gold {job.gold}-> ");

                                            job.gold += 2500.0f;

                                            Random random2 = new Random();

                                            int bonusgoldrad = (int)job.atk;

                                            float bonusgold = random2.Next(bonusgoldrad, 21);

                                            job.gold += 2500.0f * (bonusgold * 0.01f);

                                            Console.WriteLine($"{job.gold}\n");

                                            job.clearcount += 1;

                                            if (job.hp <= 0.0f)
                                            {
                                                Console.WriteLine($"{job.name}님이 사망하셨습니다.");
                                                Environment.Exit(0);
                                            }

                                            while (true)

                                            {
                                                Console.WriteLine("\n0. 나가기\n원하시는 행동을 입력해주세요.");

                                                int intrss = int.Parse(Console.ReadLine());

                                                if (intrss != 0) Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");

                                                if (intrss == 0) break;
                                            }
                                        }
                                    }
                                    else if (job.def >= 17)
                                    {
                                        Console.WriteLine("던전 클리어\n축하합니다!!\n어려운 던전을 클리어하였습니다.\n[탐험 결과]\n");
                                        Console.WriteLine($"체력 {job.hp}-> ");

                                        Random random1 = new Random();

                                        int damage = random1.Next(20 + (int)job.def - 17, 36 + (int)job.def - 17);

                                        job.hp -= damage;

                                        Console.WriteLine($"{job.hp}\n");

                                        Console.WriteLine($"Gold {job.gold}-> ");

                                        job.gold += 2500.0f;

                                        Random random2 = new Random();

                                        int bonusgoldrad = (int)job.atk;

                                        float bonusgold = random2.Next(bonusgoldrad, 21);

                                        job.gold += 2500.0f * (bonusgold * 0.01f);

                                        Console.WriteLine($"{job.gold}\n");

                                        job.clearcount += 1;

                                        if (job.hp <= 0.0f)
                                        {
                                            Console.WriteLine($"{job.name}님이 사망하셨습니다.");
                                            Environment.Exit(0);
                                        }

                                        while (true)

                                        {
                                            Console.WriteLine("\n0. 나가기\n원하시는 행동을 입력해주세요.");

                                            int intrss = int.Parse(Console.ReadLine());

                                            if (intrss != 0) Console.WriteLine("상호작용에 맞는 숫자를 입력해주세요.");

                                            if (intrss == 0) break;
                                        }

                                    }
                                    break;

                            }
                            if (intrs == 0) break;

                            else
                            {
                                break;
                            }

                            break;

                        }
                        break;

                }

                continue;
            }


        }


    }


}




