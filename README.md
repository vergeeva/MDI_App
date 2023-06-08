# MDI_App
Проект для видео на ютубе https://youtu.be/jTI2y0lPj7E

### Открытие дочерней формы из материнской:
> Form childForm = new Имя_открываемой_формы(this); <br>
> childForm.MdiParent = this; <br>
> childForm.Show(); <br>

>> Подключение данных делать только в MDI-форму

### ХРАНИМЫЕ ПРОЦЕДУРЫ:
<details><summary>ДОБАВЛЕНИЕ:</summary>   
ALTER PROCEDURE [dbo].[ИМЯ_ВАШЕЙ_ПРОЦЕДУРЫ]   <br>
	@ИМЯ_ПАРАМЕТРА1 ТИП_ДАННЫХ,    <br>
	@ИМЯ_ПАРАМЕТРА2 ТИП_ДАННЫХ  <br>  
AS   <br>
BEGIN   <br>
	SET NOCOUNT ON;   <br>
	INSERT ИМЯ_ТАБЛИЦЫ (ПОЛЕ_ТАБЛИЦЫ1, ПОЛЕ_ТАБЛИЦЫ2) VALUES (@ИМЯ_ПАРАМЕТРА1, @ИМЯ_ПАРАМЕТРА2)   <br>
END   <br>
</details>   
<details><summary>ОБНОВЛЕНИЕ:</summary>      
ALTER PROCEDURE [dbo].[Update_Акт] <br>
	@КОД ТИП_ДАННЫХ,<br>
	@ИМЯ_ПАРАМЕТРА1 ТИП_ДАННЫХ,  <br>  
	@ИМЯ_ПАРАМЕТРА2 ТИП_ДАННЫХ  <br>
AS <br>
BEGIN <br>
	SET NOCOUNT ON; <br>
	UPDATE ИМЯ_ТАБЛИЦЫ SET ПОЛЕ_ТАБЛИЦЫ1 = @ИМЯ_ПАРАМЕТРА1, ПОЛЕ_ТАБЛИЦЫ2 = @ИМЯ_ПАРАМЕТРА2, <br>
	WHERE КОД_ЗАПИСИ = @КОД <br>
END <br>
</details>
<details><summary>УДАЛЕНИЕ:</summary>     
ALTER PROCEDURE [dbo].[Delete_План] <br>
	@КОД ТИП_ДАННЫХ,<br>
AS <br>
BEGIN <br>
	SET NOCOUNT ON; <br>
	DELETE ИМЯ_ТАБЛИЦЫ WHERE WHERE КОД_ЗАПИСИ = @КОД <br>
END <br>
</details> 

### СХЕМА ДАННЫХ:

![Frame schema](https://github.com/vergeeva/MDI_App/assets/61785118/981f4cfd-5943-46e5-9f1e-a4b4c18d08a3)
> Схему можно усложнить, создав отдельную таблицу для получателей

### ПРЕДСТАВЛЕНИЯ ДЛЯ ОТЧЕТОВ В ВИДЕ ЗАПРОСОВ:

<details><summary>Расчет отчислений по факту</summary>
SELECT dbo.МатериальныеЦенности.Код_марки, dbo.МатериальныеЦенности.Наименование, dbo.Акты.Первоначальная_стоимость, dbo.Акты.Фактический_износ, <br>
	(dbo.Акты.Первоначальная_стоимость + dbo.Акты.Фактический_износ) / 100 AS Сумма_отчислений_факт <br>
FROM	dbo.Акты INNER JOIN <br>
	dbo.МатериальныеЦенности ON dbo.Акты.Код_материала = dbo.МатериальныеЦенности.Код_марки <br>
</details>
<details><summary>Ведомость</summary>
SELECT dbo.МатериальныеЦенности.Код_марки, dbo.МатериальныеЦенности.Наименование, dbo.Акты.Первоначальная_стоимость, 
	dbo.Акты.Фактический_износ, dbo.План.Плановый_износ,   <br>
        (dbo.Акты.Первоначальная_стоимость + dbo.Акты.Фактический_износ) / 100 AS Сумма_отчислений_факт,  <br>
	(dbo.Акты.Первоначальная_стоимость + dbo.План.Плановый_износ) / 100 AS Сумма_отчислений_план,  <br>
        (dbo.Акты.Первоначальная_стоимость + dbo.План.Плановый_износ) / 100 -  <br>
	(dbo.Акты.Первоначальная_стоимость + dbo.Акты.Фактический_износ) / 100 AS Отклонение  <br>
FROM     dbo.Акты INNER JOIN  <br>
                  dbo.МатериальныеЦенности ON dbo.Акты.Код_материала = dbo.МатериальныеЦенности.Код_марки INNER JOIN  <br>
                  dbo.План ON dbo.МатериальныеЦенности.Код_марки = dbo.План.Код_материала  <br>
</details>

### Для фильтрации данных в таблице

<details><summary>Вызов функции фильтра</summary>
bool result = MainForm.RunFilter(MainForm.Имя_биндинг_соурса, Текстовое_поле_фильтра.Text, По_какому_полю_сортировка.Text); <br>
if (!result) <br>
{ <br>
&emsp;	MessageBox.Show("Ошибка запроса"); <br>
} <br>
</details>

<details><summary>Реализация функции</summary>
public bool RunFilter(BindingSource binding, string value, string field)//биндинг, значение фильтра, поле для фильтрации <br>
&emsp;{//задать фильтр таблице <br>
&emsp;&emsp;try <br>
&emsp;&emsp;&emsp;{ <br>
&emsp;&emsp;&emsp;if (value == "" && field == "") <br>
&emsp;&emsp;&emsp;{//если поле и значение не указано <br>
&emsp;&emsp;&emsp;&emsp;binding.Filter = "";//присваиваем пустой фильтр <br>
&emsp;&emsp;&emsp;&emsp;return true;//фильтр сработал, возвращаем <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;if (int.TryParse(value, out _)) <br>
&emsp;&emsp;&emsp;{//если число <br>
&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] = {1}", field, value); <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;else <br>
&emsp;&emsp;&emsp;{//если пользователь использует знаки <br>
&emsp;&emsp;&emsp;&emsp;if (value[0] == '<' || value[0] == '>' || value[0] == '=') <br>
&emsp;&emsp;&emsp;{ <br>
&emsp;&emsp;&emsp;&emsp;if ((int.TryParse(value.Substring(1), out _)) || (value[1] == '=' && int.TryParse(value.Substring(2), out _))) <br>
&emsp;&emsp;&emsp;&emsp; {//для чисел <br>
&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] {1}", field, value); <br>
&emsp;&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;&emsp; else if (DateTime.TryParse(value.Substring(1), out _)) <br>
&emsp;&emsp;&emsp;&emsp;{//если знак однозначный для даты <br>
&emsp;&emsp;&emsp;&emsp;&emsp;char mark = value[0]; <br>
&emsp;&emsp;&emsp;&emsp;&emsp;value = Convert.ToDateTime(value.Substring(1)).ToString().Replace('.', '-'); <br>
&emsp;&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value); <br>
&emsp;&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;&emsp;else if (value[1] == '=' && DateTime.TryParse(value.Substring(2), out _)) <br>
&emsp;&emsp;&emsp;&emsp;{//если знак из двух знаков для даты <br>
&emsp;&emsp;&emsp;&emsp;&emsp;string mark = value.Substring(0, 2); <br>
&emsp;&emsp;&emsp;&emsp;&emsp; //конвертируем дату, так как для сравнения формат даты немного другой <br>
&emsp;&emsp;&emsp;&emsp;&emsp;value = Convert.ToDateTime(value.Substring(2)).ToString().Replace('.', '-'); <br>
&emsp;&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value); <br>
&emsp;&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;else <br>
&emsp;&emsp;&emsp;{//для строк <br>
&emsp;&emsp;&emsp;&emsp;if (value[value.Length - 1] == '*') <br>
&emsp;&emsp;&emsp;&emsp;{//если есть звездочка <br>
&emsp;&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] like '{1}'", field, value); <br>
&emsp;&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;&emsp;else if (DateTime.TryParse(value, out _)) <br>
&emsp;&emsp;&emsp;&emsp;{//если дата без знаков <br>
&emsp;&emsp;&emsp;&emsp;&emsp;//конвертируем дату, так как для сравнения формат даты немного другой <br>
&emsp;&emsp;&emsp;&emsp;&emsp;value = Convert.ToDateTime(value).ToString().Replace('.', '-'); <br>
&emsp;&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] = '{1}'", field, value); <br>
&emsp;&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;&emsp;else <br>
&emsp;&emsp;&emsp;&emsp;{//если строка без звездочки <br>
&emsp;&emsp;&emsp;&emsp;&emsp;binding.Filter = String.Format("[{0}] like '{1}*'", field, value); <br>
&emsp;&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;return true; <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;&emsp;catch <br>
&emsp;&emsp;&emsp;{ <br>
&emsp;&emsp;&emsp;&emsp;return false; <br>
&emsp;&emsp;&emsp;} <br>
&emsp;&emsp;} <br>
</details>
