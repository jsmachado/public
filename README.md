RESPOSTA:
Machado,

Implementei o SignalR utilizando uma biblioteca que tive que utilizar em um outro projeto e que achei simples e boa. 

Ela já facilita bastante a transformação de notificações em observables (rx/JS).

Dá uma olhada no git log para ver o historico de alterações e como implementar. Qualquer dúvida me liga que batemos um papo.

Para testar a solução:

1. git clone
2. entra no \umbrella-client e dá um npm install
3. roda o projeto mvc no visual studio
4. coloca o endereço do mvc em \umbrella-client\src\environments\environment.ts na propriedade signalrUrlBase
5. roda "ng serve" no diretorio \umbrella-client


Lógico que colocando isso em produção daria pra fazer um scriptzinho e tal que faz tudo, mas preguiça hehe.
Qualquer problema me fala. Abs!



Rapha,

Solução ASP.Net MVC mínima com o SignalR funcionando.

Configurada para .Net 4.6.1, com SignalR 2.2.

Removi tudo desnecessário, o único supérfluo que existe é o bootstrap.

[]'s

Machado