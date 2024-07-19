
using System.Reflection.Metadata;

//Değişkenler tanımlanıyor
Dictionary<int, char> answers=new Dictionary<int, char>();
answers.Add(1, 'A');
answers.Add(2, 'A');
answers.Add(3, 'B');

int score = 0;
char contestantAnswer;

Console.WriteLine("Soruları cevaplayarak 1 Milyon Tl kazanabilirsiniz... ");
Console.WriteLine("\n");


// 1. Soru....................................................................
Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine(" a) Lama  b) Deve");
Console.Write("Cevabınız....:");
contestantAnswer = Convert.ToChar((Console.ReadLine()).ToUpper());

if (answers[1]==contestantAnswer)
{
    score = 1;
    Console.WriteLine("Tebrikler,doğru bildiniz!");
}
else
{
    Console.WriteLine("Üzgünüz,yanlış cevap!");
}
Console.WriteLine("\n");


// 2. Soru.........................................................................

Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine(" a) Venüs b) Mars");
Console.Write("Cevabınız....:");
contestantAnswer = Convert.ToChar((Console.ReadLine()).ToUpper());

if (answers[2] == contestantAnswer)
{
    score += 1;
    Console.WriteLine("Tebrikler,doğru bildiniz!");
}
else
{
    Console.WriteLine("Üzgünüz,yanlış cevap!");
}
Console.WriteLine("\n");



//Yarışmacı ilk  2 soruyu doğru veya yanlış cevapladığı için 3 soruyu cevaplamasına gerek yok.  
if ((score >0)&&(score<2))
{ 

//3. Soru............................................................................
Console.WriteLine("3-> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
Console.WriteLine(" a) 7 b) 12 ");
Console.Write("Cevabınız....:");
contestantAnswer = Convert.ToChar((Console.ReadLine()).ToUpper());

if (answers[3] == contestantAnswer)
{
    score += 1;
    Console.WriteLine("Tebrikler,doğru bildiniz!");
}
else
{
    Console.WriteLine("Üzgünüz,yanlış cevap!");
}
 
}


Console.WriteLine("\n");
if (score>=2)
{
    Console.WriteLine("Tebrikler,en az iki soruya doğru cevap verdiniz ve 1 Milyon TL'lik büyük ödülü kazandınız!");
    
}
else
{
    Console.WriteLine("Üzgünüz, en az iki soruya doğru cevap vermeniz gerekiyordu!");
}
Console.WriteLine($"Skorunuz...:{score}");



