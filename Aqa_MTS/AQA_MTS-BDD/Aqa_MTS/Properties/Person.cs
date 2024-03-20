namespace Properties;

public class Person
{
    private string name;
    private int age;

    private string surname;
    private string address;

    public Person()
    {
        surname = "Фамилия";
        Address = "Москва";   //установиили значениие используя свойство
    }
    
    //стандартный вариант работы с блоком данных
    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
    
    // В C# есть Свойство для доступа к полю name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            //Логика проверки при установке значения (если значение не пустое)
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    //свойство только для записи - когда переменная используется только внутри класса для расчетов
    public int Age
    {
        set { age = value; }
    }
    
    //свойство только для чтения
    public string Surname
    {
        get { return surname; }
    }
    
    //Вычсляемые свойства
    public string Fullname
    {
        get { return $"{name} {surname}"; }
    }
    
    //Модификаторы доступа

    public string Address
    {
        get { return Address; }

       // private set { address = value; }
        protected set { address = value; }  //из дочернего класса можно установить значение
    }
    
    //Автоматические свойства
    //свойство для задания ии возврата значения
   // public string Salary { get; set; }
   //public int Salary { get; set; } = 12500;  //задать сразу значениие по умолчанию
   public string Salary { get; private set; }  //с указанием доступа
   
   //Блок init
   //Первый способ
   public string ID { get; init; } = "XXX-712";
   
   //Второй способ  - создаем пустой конструктор для инициализации переменной свойства
  // public Person(string id) => ID = id;
   
   //Модификатор required
   /*public required string Passport { get; set; } //ошибка при вызове базового конструктора

   public Person(string passport)
   {
       Passport = passport;
   }*/
}