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

 
	public bool RunFilter(BindingSource binding, string value,string field)  //биндинг, значение фильтра, поле для фильтрации
	{                  //задать фильтр таблице
	  try {
	    if (value == "" && field == "") {  //если поле и значение не указано
	      binding.Filter = "";  //присваиваем пустой фильтр
	      return true;  //фильтр сработал, возвращаем
	    }
	    if (int.TryParse(value, out _)) {  //если число
	      binding.Filter = String.Format("[{0}] = {1}", field, value);
	    } else {  //если пользователь использует знаки
	      if (value[0] == '<' || value[0] == '>' || value[0] == '=') {
	        if ((int.TryParse(value.Substring(1), out _)) ||
	            (value[1] == '=' &&
	             int.TryParse(value.Substring(2), out _))) {  //для чисел
	          binding.Filter = String.Format("[{0}] {1}", field, value);
	        } else if (DateTime.TryParse(value.Substring(1),
	                                     out _)) {  //если знак однозначный для даты
	          char mark = value[0];
	          value = Convert.ToDateTime(value.Substring(1))
	                      .ToString()
	                      .Replace('.', '-');
	          binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value);
	        } else if (value[1] == '=' &&
	                   DateTime.TryParse(
	                       value.Substring(2),
	                       out _)) {  //если знак из двух знаков для даты
	          string mark = value.Substring(0, 2);
	          //конвертируем дату, так как для сравнения формат даты немного другой
	          value = Convert.ToDateTime(value.Substring(2))
	                      .ToString()
	                      .Replace('.', '-');
	          binding.Filter = String.Format("[{0}] {1}'{2}'", field, mark, value);
	        }
	      } else {                                 //для строк
	        if (value[value.Length - 1] == '*') {  //если есть звездочка
	          binding.Filter = String.Format("[{0}] like '{1}'", field, value);
	        } else if (DateTime.TryParse(value, out _)) {  //если дата без знаков
	          //конвертируем дату, так как для сравнения формат даты немного другой
	          value = Convert.ToDateTime(value).ToString().Replace('.', '-');
	          binding.Filter = String.Format("[{0}] = '{1}'", field, value);
	        } else {  //если строка без звездочки
	          binding.Filter = String.Format("[{0}] like '{1}*'", field, value);
	        }
	      }
	    }
	    return true;
	  } catch {
	    return false;
	  }
	}
