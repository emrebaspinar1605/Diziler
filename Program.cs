//Dizi Tanimlama
string[] colors = new string[5];

string[] animals={"Kedi","Köpek","Kuş","Maymun"};

int[] array;
array=new int[5];

//Dizilere Değer Atama ve Erişim

colors[0]="Mavi";
array[3]=10;

System.Console.WriteLine(animals[1]);
System.Console.WriteLine(array[3]);
System.Console.WriteLine(colors[0]);

//Döngülerle dizi kullanımı
//Klavyeden girilen "n" tane sayının ortalamasını hesaplayan program
System.Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int arrayLength=Convert.ToInt32(Console.ReadLine());
int[] numberArray=new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    System.Console.WriteLine("Lütfen {0}. sayıyı giriniz",i+1);
    numberArray[i]=int.Parse(Console.ReadLine());
}
int toplam=0;
foreach (var number in numberArray)
{
    toplam+=number;
}
System.Console.WriteLine("Ortalama: "+toplam/arrayLength);