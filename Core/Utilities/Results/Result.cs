using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success) // this burada bizim classimiz bildirir yeni 1 parametrli consa succesi yolla.Yeni 2 parametrli yollayanda asagidaki da isliyer.
                                                                  // uzun sozun qisasi 2 parametrli consumuz onsuz isleyir(true olanda) bu classdaki 1 parametrli(success) consu da islesin.2 parametrli yazsaq onsuz thisi yene ozunu islederdi
                                                                  // yeni ki 2 parametrli resultimiz 1 parametri ehata etdiyi ucun o da islemelidi ona gore thisden istifade etdik.
        {
            Message = message; // be biz burada demisdik ki Messageler set oluna bilmez.Amma burada getlerimiz READ-ONLY oldugu ucun biz burada set vere bilerik.
                               // Amma yalniz Constructor daxilinde set eliye bilerik(GETI).Biz burada setle versek adam istediyi kimi kodlari yazacaq(// icinde yazmisam) lakin biz burda GET ile verdiyimiz ucun yazilan kod daha da spesifiklesecek yeni biz Constructorda islemeyini isteyirik.
                               // Biz Setle versek orda qeyd elemisemki gerek success. le yazsin lakin biz get ile vererek bunlarin constructorun daxilinde verilmesini isteyirik
        }

        public Result(bool success) // yeni ki biz mesajin gelmeyini istemirikse bele elemeliyik
                                    // Yuxardaki constructorumuz asagidaki constructoru ehate etdiyine gore biz 1ci success = successi silib 2cide saxlayiriq
                                    // yeni ki onsuz 1ci consu isleden message vermek isteyir bu ise ikinci consu da ehate edir.Lakin 2ci isleden mesaj vermek istemir ve buarada 1ci consdan istifade etmir
        {
            Success = success;
        }

        public bool Success { get;  }

        public string Message { get; }
    }
}
