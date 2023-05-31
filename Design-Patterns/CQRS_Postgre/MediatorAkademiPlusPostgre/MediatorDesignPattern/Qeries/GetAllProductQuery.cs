using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Qeries
{
    //bu kez bir parametre olmasa dahi resultımızı bir şeye bağlıyor olacağız. normalde burada parametre veriyorduk
    // irequest interfacesini dahil ediyoruz. mediatorun 2 çıktısı olacak. biri istekte bulunan yer biriyse onun çıktısı.
    public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>> // ben buradan bir istekte bulunduğumda bana List<GetAllProductQueryResult> burayı döndürecek
    {
    }
}
