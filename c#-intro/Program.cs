/// <summary>
/// System bir namespace'dir.
/// Bunu Bir otaq kimi təsəvvür edə bilərsiniz.
/// using -> bu ifadə ilə bir növ otağa daxil oluruq,
/// bunu istifadə edəcəyimizi bildiririk, (açar söz <-> keyword)
/// Hansı ki özündə müəyyən xüsusiyyətləri saxlayır.
/// Misal üçün təmir otağında necə ki, müəyyən alətlər olur
/// System ifadəsinin üstünə mouse oxun gətirib saxladiqda 
/// (namespace System) <-ifadəsin görəcəyik
/// </summary>
using System;


///<summary>
/// namesapace'də C#-ın keyword'üdür
/// namespace-in adı project adina gore tamamlanir
/// Solution və Project name
/// Bir solution problemin həll yolu deməkdir yeni ümumi anlayişdır.
/// Misal üçün solutionu bir ev kimi tesevvür edə bilərsiniz
/// Bir solution daxilində birdən çox project ola bilər yəni otaq
/// və özlüyündə müxtəlif problemlərin həllin daşıyar
///</summary>
namespace c__intro
{
    /// <summary>
    /// public bir access modifier-dır və oda keyword-dür
    /// class tercümə baximdan sinif mənasın daşır irəli dərslərdə 
    /// bu barədə danışacağıq Program isə bu classın adıdır 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// (static ,void) -> keyword
        /// Main() -> bu bir metoddur irəli derslerde danışacağıq
        /// Main metodu Program sinifinin bir üzvüdür 
        /// Misal üçün kalkulyatorda (toplama, çıxma) və.s işlər görür və kalk programinin bir funksiyasidir,
        /// burdada Main bir iş görən hissədir  yəni funksiya və ya metod
        /// </summary>
        /// <param name="args">aşaqıda main metodunun içində olan string[] args -> ireli dərsdə</param>
        static void Main(string[] args)
        {
            ///<summary>
            /// Console bu bir class-dır yəni sinif
            /// WritwLine() bu bir metoddur hansıki Console Classının daxilindədir
            /// WritwLine() vəZifəsi ekrana hansısa məlumatı yazını çap etmək üçündür
            /// Əgər siz using System ifadəsin silsəniz  Console klasssinin altindan
            /// dalğalı qırmızı xett çəkəcək bunun mənası bir xətanın baş verdiyini bildirir.
            /// Xəta error deməkdir və bu zaman compile time error verir
            /// Səbəbidə odurki siz console ifadəinin üzrəinə mouse ilə gəlib
            /// ctrl düyməsini sıxıb saxlayıb və mouse-nin sol düyməsini click etsəniz
            /// sizi bir başa olaraq system namespace aparir ve Console classi bu namespace daxilindən gəlir
            /// Ona görə siz namespace Systemi siləndə xəta alırsınız və Console classindan istifade ede bilmirsiniz
            /// Bu zaman program işə düşmür
            ///</summary>
            Console.WriteLine("Hello World!");
        }
    }
}
