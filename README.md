<h1>MyTrips_projetoEstagio</h1>

<h2>Avaliação técnica<h2>
  
![homeMobile](https://user-images.githubusercontent.com/47716277/54581395-48db8900-49eb-11e9-86e1-59255a37bb0b.PNG)

<p>Com essa avaliação tive a oportunidade de aprender muita coisa, em pouco tempo. Meu conhecimento na linguagem era zero, nunca tive contato com dotnet, mas procurei dar o meu melhor.</p>

<br>

<p>Como sou usuário do linux, fiz o projeto em dotnet core, a versão mais atual, comecei usando Visual Studio Code, com algumas extensões, é o dotnet core instalado, compilando via terminal, mas por motivos técnicos(Notebook travando), tive que trocar de máquina, e continuei o projeto no Windows.</p>

![homeFull](https://user-images.githubusercontent.com/47716277/54581845-1fbbf800-49ed-11e9-826c-3caaf3d7dd05.PNG)

<h2>Tecnologias Utilizadas</h2>
<ul>
  <li>.Net Core</li>
  <li>Entity Framework Core</li>
  <li>C-Sharp</li>
  <li>Sql Server</li>
  <li>Html 5</li>
  <li>Css 3</li>
</ul>

<h3>Arquivo Json</h3>

<p>Arquivo Json depois de lido, é armazenado em uma variável, e depois convertido em um objeto</p>
  
 ![arq Json](https://user-images.githubusercontent.com/47716277/54582290-f603d080-49ee-11e9-80dc-2fdb3196c953.png)
 
 '''
 
         private static List<Hotel> GetHost()
        {
            var Json = File.ReadAllText("trips.json");

            var hotel = JsonConvert.DeserializeObject<List<Hotel>>(Json);
            return hotel;
        }
 '''
 
 <p>O conteúdo desse Json é armazenado no Banco de Dados, criado através de migrações.</p>
 
 '''
 
         public void InicializaDB()
        {
            contexto.Database.Migrate();

            List<Hotel> hotel = GetHost();

            hostRepository.SaveHost(hotel);

        }
        
'''
 
 ![Salvando no banco de dados](https://user-images.githubusercontent.com/47716277/54582575-05cfe480-49f0-11e9-871e-77d9ae4b8a8b.PNG)
 
 <h2>Home</h2>
 
 <p>Como foi usado padrão mvc, a home(index), é adicionada no meio de uma outra página html, com intuito de que se tivermos outras páginas, podemos ter elementos fixos, que serão compartilhadas com todas as demais páginas centrais. Apesar de não ter sido o caso dessa aplicação, resolvi usar para me adaptar com essa forma de desenvolver</p>
 
 '''
 
         @{
            DateTime dataHoje = DateTime.Today;
            foreach (var hotel in Model)
            {
                DateTime dataHotel = DateTime.Parse(hotel.date);
                int result = DateTime.Compare(dataHotel, dataHoje);
                if (hotel.cityId == 132 && result >= 0)
                {
                    <div class="card-teste">
                        <div class="card-img">
                            <img src="@hotel.thumb">
                        </div>
                        <div class="card-infos">
                            <div class="card-infos-interno">
                                @if (hotel.stars == 5)
                                {
                                    <p class="stars">
                                        <i class="fas fa-star colorStar"></i><i class="fas fa-star colorStar"></i>
                                        <i class="fas fa-star colorStar"></i><i class="fas fa-star colorStar"></i><i class="fas fa-star colorStar"></i>
                                    </p>
                                }
                                else if (hotel.stars == 4)
                                {
                                    <p class="stars">
                                        <i class="fas fa-star colorStar"></i><i class="fas fa-star colorStar"></i>
                                        <i class="fas fa-star colorStar"></i><i class="fas fa-star colorStar"></i>
                                    </p>
                                }
                                else if (hotel.stars == 3)
                                {
                                    <p class="stars">
                                        <i class="fas fa-star colorStar"></i><i class="fas fa-star colorStar"></i>
                                        <i class="fas fa-star colorStar"></i>
                                    </p>
                                }

                            </div>
                            <div class="card-infos-interno nomeHotel">
                                <h3 id="nomeHotel">@hotel.hotelName</h3>
                            </div>
                            <div class="card-infos-interno localHotel">
                                <p id="localHotel">@(hotel.location), Dubai</p>
                            </div>
                            <div class="card-infos-interno precoHotel">
                                <p id="precoHotel">@(hotel.price)€</p>
                            </div>
                        </div>
                    </div>
                    
'''

<p>Como foi pedido, essa parte do código compara a data de hoje(sistema), com a data dos hóteis, e exibe somente as com data superior, também é comparado o ID da cidade.<br>Na div que lista as informações dos hoteis, foi feito uma condição, comparado a quantidade de estrelhas de cada hotel, e mostrar na tela respectivamente</p>
<br>
<h4>Para rodar o projeto</h4>

![start](https://user-images.githubusercontent.com/47716277/54583373-af17da00-49f2-11e9-9f62-f7c98fced4cf.PNG)

<p>Basta abrir no Visual Studio 2015 ou superior e dar um Start</p>

<br>

<p>Apesar das dificuldades, tentei entregar o máximo que consegui, e o que não consegui, vou correr atrás e aprender, apesar da falta de experiência, eu gosto de programar, e hoje sei que quero isso para minha vida.</p>



