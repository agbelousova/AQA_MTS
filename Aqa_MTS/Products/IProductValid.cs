namespace Products;

internal interface IProductValid
{
    //выделен интерфейс общй для товаров, у которых есть общий метод для определения срока годности
    bool IsValid(DateTime expiriationDate);
}