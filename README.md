# vp_project_task_manager

### Име на проектот: Task Manager VP
### Студент: Лазар Стојановски 153116
### Опис: 
Аплкацијата има за цел да послужи како уредувач на апликативни и системски задачи.
Идејата потекнува од управувачот на задачи од оперативниот систем Windows, односно интересот за работа со системски и апликативен софтвер во овој ос, како и 
потребата за по детално истражување и проучување на програмските библиотеки од истиот. Апликацијата е изработена во програмскиот јазик C# и .NET Framework, по детални информации
следат подолу.


### Вклучува опции како: 
    - Листање на сите активни процеси кои што се извршуваат во моментот
    - Креирање нов процес 
    - Терминирање на активен процес
    - Освежување на листата
    - Перформанс таб во реално време
    
### Технички спецификации:

Програмски јазик: C#
Работна рамка: .NET Framework v4.7


### Опции:
  - ##### Листање на сите активни процеси
          Оваа задача се реализира преку метод GetProcesses() која за цел има да ги пронајде сите активни процеси и да ги смести во контрола од типот ListView каде што
          секоја ставка претставува комбинација од повеќе својства на еден процес и тоа име, id на процесот, кој го поседува (системски или кориснички), 
          и приоритет на извршување.
          За да се извршат овие операции во наведениот метод го користам именскиот простор System.Diagnostics кој ги содржи функциите за добивање 
          на активни процеси како и самата Process класа. 
          
  - ##### Креирање на нов процес
          
          За оваа цел креирана е нова дополнителна форма именувана како Run која исто како опцијата за нова задача на Windows Task manager се состои од поле за пишување
          на името на бараната апликација и копчиња ОК и Cancel. Името на апликацијата што треба да се отвори може да се пише како пр. notepad.exe или само notepad без екстензија
  
  - ##### Терминирање на активен процес
          За да се терминира еден процес треба прво да се селектира од листата со активни процеси, по завршувањето листата се освежува
          
  - ##### Освежување на листата
          Целта на освежувањето на листата е тоа што самата листа не е во реално време односно по секоја промена има потреба да се освежува, тоа се прави или по завршена операција како New task, End task или рачно побарување за освежување. Рачното освежување се извршува преку View > Refresh now опцијата во контекстуалното мени или преку копчето налик симбол за "refresh" кое се наоѓа во десната страна одма над листата со процеси.
        
    ```cs
    private void RefreshList()
        {
            if (lstProcesses.Items.Count != 0)
            {
                lstProcesses.Items.Clear();
            }

            GetProcesses();
        }
    ```
    
  - ##### Перформанс таб во реално време
          Овој таб содржи процентуална искористеност на процесорот и рам меморијата притоа визуелизирана со progress bar и график за визуелизација на податоци.
          Работи на принцип на тајмер кој се променува на 1 секунда и ги ажурира податоците, за таа цел се искористени контроли од типот PerformanceCounter и Timer.
          Целиот процес се одвива преку евентот timer_tick кој се случува на секоја секунда од започнувањето на формата па се дури не се затвори целата апликација.
          
    ```cs
    private void timer_Tick(object sender, EventArgs e)
        {
            float fCpu = perfCPU.NextValue();
            float fRam = perfRAM.NextValue();

            progCPU.Value = (int)fCpu;
            progRAM.Value = (int)fRam;

            lblCPUPerc.Text = string.Format("{0:0.00}%", fCpu);
            lblRAMperc.Text = string.Format("{0:0.00}%", fRam);

            perfChart.Series["CPU"].Points.AddY(fCpu);
            perfChart.Series["RAM"].Points.AddY(fRam);
        }
    ```
