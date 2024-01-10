// See https://aka.ms/new-console-template for more information
/*Задание 1:
Создать класс, в котором будет статический метод. Этот метод принимает на вход три параметра:
- login,
- password,
- confirmPassword.

1. Все поля имеют тип данных String.
2. Длина login должна быть меньше 20 символов и не должен содержать пробелы.
3. Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
4. Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен 
содержать хотя бы одну цифру.
5. Также password и confirmPassword должны быть равны.
6. Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
7. WrongPasswordException и WrongLoginException - пользовательские классы исключения с 
двумя конструкторами – один по умолчанию, второй принимает сообщение исключения и передает его 
в конструктор класса Exception.
8/ Метод возвращает true, если все значения верны или false в другом случае.
*/

using Exceptions_HM;

Authorization authorization = new Authorization();
authorization.Run();