
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
<ya-tr-span data-index="19-0" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="pipeline {  " data-translation="конвейер {  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">конвейер {
 </ya-tr-span><ya-tr-span data-index="19-1" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="// Run on any available Jenkins agent.  " data-translation="// Запуск на любом доступном агенте Jenkins.  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">// Запуск на любом доступном агенте Jenkins.
 </ya-tr-span><ya-tr-span data-index="19-2" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="agent any  options {  " data-translation="агент любой   опции {  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">агент любой 
 опции {
 </ya-tr-span><ya-tr-span data-index="19-3" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="// Show timestamps in the build.  " data-translation="// Показывать временные метки в сборке.  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">// Показывать временные метки в сборке.
 </ya-tr-span><ya-tr-span data-index="19-4" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="timestamps()  " data-translation="временные метки()  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">временные метки()
 </ya-tr-span><ya-tr-span data-index="19-5" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="// Prevent more than one build from running at a time for this project.  " data-translation="// Запретить одновременный запуск более одной сборки для этого проекта.  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">// Запретить одновременный запуск более одной сборки для этого проекта.
 </ya-tr-span><ya-tr-span data-index="19-6" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="disableConcurrentBuilds()  " data-translation="Отключить Concurrentbuilds()  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">Отключить Concurrentbuilds()
 </ya-tr-span><ya-tr-span data-index="19-7" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="// If Jenkins restarts or the client disconnects/reconnects, abandon the current build instead of trying to continue.  " data-translation="// Если Jenkins перезапустится или клиент отключится / повторно подключится, откажитесь от текущей сборки вместо того, чтобы пытаться продолжить.  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">// Если Jenkins перезапустится или клиент отключится / повторно подключится, откажитесь от текущей сборки вместо того, чтобы пытаться продолжить.
 </ya-tr-span><ya-tr-span data-index="19-8" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="disableResume()  " data-translation="disableResume()  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">disableResume()
 </ya-tr-span><ya-tr-span data-index="19-9" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="}  triggers {  " data-translation="}   запускает {  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">} 
 запускает {
 </ya-tr-span><ya-tr-span data-index="19-10" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="// Poll source control periodically for changes.  " data-translation="// Периодически опрашивает систему управления версиями на предмет изменений.  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">// Периодически опрашивает систему управления версиями на предмет изменений.
 </ya-tr-span><ya-tr-span data-index="19-11" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="pollSCM 'H * * * *'  " data-translation="pollSCM 'H * * * *'  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">pollSCM 'H * * * *'
 </ya-tr-span><ya-tr-span data-index="19-12" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="}  stages {  stage('This is a test!') {  " data-translation="}   этапы {   этап ('Это тест!') {  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">} 
 этапы { 
 этап ('Это тест!') {
 </ya-tr-span><ya-tr-span data-index="19-13" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="steps {  script {  " data-translation="шаги {   скрипт {  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">шаги { 
 скрипт {
 </ya-tr-span><ya-tr-span data-index="19-14" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="print 'Hello World!'  }  }  }  " data-translation="напечатать 'Привет, мир!'  }  }  }  " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">напечатать 'Привет, мир!'
 }
 }
 }
 </ya-tr-span><ya-tr-span data-index="19-15" data-translated="true" data-source-lang="en" data-target-lang="ru" data-value="} } " data-translation="} } " data-ch="0" data-type="trSpan" style="visibility: inherit !important;">}
}
</ya-tr-span>