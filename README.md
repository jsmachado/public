RESPOSTA:
Machado,

Implementei o SignalR utilizando uma biblioteca que tive que utilizar em um outro projeto e que achei simples e boa. 

Ela j� facilita bastante a transforma��o de notifica��es em observables (rx/JS).

D� uma olhada no git log para ver o historico de altera��es e como implementar. Qualquer d�vida me liga que batemos um papo.

Para testar a solu��o:

1. git clone
2. entra no \umbrella-client e d� um npm install
3. roda o projeto mvc no visual studio
4. coloca o endere�o do mvc em \umbrella-client\src\environments\environment.ts na propriedade signalrUrlBase
5. roda "ng serve" no diretorio \umbrella-client


L�gico que colocando isso em produ��o daria pra fazer um scriptzinho e tal que faz tudo, mas pregui�a hehe.
Qualquer problema me fala. Abs!



Rapha,

Solu��o ASP.Net MVC m�nima com o SignalR funcionando.

Configurada para .Net 4.6.1, com SignalR 2.2.

Removi tudo desnecess�rio, o �nico sup�rfluo que existe � o bootstrap.

[]'s

Machado