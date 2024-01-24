using Microsoft.AspNetCore.Mvc;
using SharpCountriesProg.Models;
using SharpRepositoryServiceProg.AAPublic;

namespace ReactApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesTreeController : ControllerBase
    {
        private readonly ILogger<Country> _logger;
        private readonly IRepositoryService repositoryService;

        public CountriesTreeController(
            ILogger<Country> logger,
            IServiceProvider provider)
        {
            _logger = logger;
            repositoryService = provider.GetService<IRepositoryService>();
        }

        [HttpGet(Name = "GetCountriesTree")]
        [Produces("application/xml")]
        public IActionResult Get()
        {
            var xml = DeafaultXml();

            return new ContentResult
            {
                ContentType = "application/xml",
                Content = xml,
                StatusCode = 200
            };
        }

        [HttpPost]
        public IActionResult Post([FromBody] string inputString)
        {

            return Ok();
        }
        
        private string DeafaultXml()
        {
            return """
<root>
  <item id="1" name="Afghanistan" isFolder="true">
    <item id="2" name="Capital" isFolder="true">
      <item id="3" name="Kabul" isFolder="false" />
    </item>
    <item id="4" name="SurfaceAreaKm2" isFolder="true">
      <item id="5" name="652230" isFolder="false" />
    </item>
    <item id="6" name="PopulationMln" isFolder="true">
      <item id="7" name="38" isFolder="false" />
    </item>
    <item id="8" name="President" isFolder="true">
      <item id="9" name="Ashraf Ghani" isFolder="false" />
    </item>
    <item id="10" name="Currency" isFolder="true">
      <item id="11" name="Afghani" isFolder="false" />
    </item>
  </item>

  <item id="12" name="Albania" isFolder="true">
    <item id="13" name="Capital" isFolder="true">
      <item id="14" name="Tirana (Tirane)" isFolder="false" />
    </item>
    <item id="15" name="SurfaceAreaKm2" isFolder="true">
      <item id="16" name="28748" isFolder="false" />
    </item>
    <item id="17" name="PopulationMln" isFolder="true">
      <item id="18" name="2.87" isFolder="false" />
    </item>
    <item id="19" name="President" isFolder="true">
      <item id="20" name="Ilir Meta" isFolder="false" />
    </item>
    <item id="21" name="Currency" isFolder="true">
      <item id="22" name="Lek" isFolder="false" />
    </item>
  </item>

  <item id="23" name="Algeria" isFolder="true">
    <item id="24" name="Capital" isFolder="true">
      <item id="25" name="Algiers" isFolder="false" />
    </item>
    <item id="26" name="SurfaceAreaKm2" isFolder="true">
      <item id="27" name="2381741" isFolder="false" />
    </item>
    <item id="28" name="PopulationMln" isFolder="true">
      <item id="29" name="44.6" isFolder="false" />
    </item>
    <item id="30" name="President" isFolder="true">
      <item id="31" name="Abdelmadjid Tebboune" isFolder="false" />
    </item>
    <item id="32" name="Currency" isFolder="true">
      <item id="33" name="Algerian Dinar" isFolder="false" />
    </item>
  </item>

  <item id="34" name="Andorra" isFolder="true">
    <item id="35" name="Capital" isFolder="true">
      <item id="36" name="Andorra la Vella" isFolder="false" />
    </item>
    <item id="37" name="SurfaceAreaKm2" isFolder="true">
      <item id="38" name="468" isFolder="false" />
    </item>
    <item id="39" name="PopulationMln" isFolder="true">
      <item id="40" name="0.08" isFolder="false" />
    </item>
    <item id="41" name="President" isFolder="true">
      <item id="42" name="Joan Enric Vives Sicília" isFolder="false" />
    </item>
    <item id="43" name="Currency" isFolder="true">
      <item id="44" name="Euro" isFolder="false" />
    </item>
  </item>

  <item id="45" name="Angola" isFolder="true">
    <item id="46" name="Capital" isFolder="true">
      <item id="47" name="Luanda" isFolder="false" />
    </item>
    <item id="48" name="SurfaceAreaKm2" isFolder="true">
      <item id="49" name="1246700" isFolder="false" />
    </item>
    <item id="50" name="PopulationMln" isFolder="true">
      <item id="51" name="32.9" isFolder="false" />
    </item>
    <item id="52" name="President" isFolder="true">
      <item id="53" name="João Lourenço" isFolder="false" />
    </item>
    <item id="54" name="Currency" isFolder="true">
      <item id="55" name="Angolan Kwanza" isFolder="false" />
    </item>
  </item>

  <item id="56" name="Antigua and Barbuda" isFolder="true">
    <item id="57" name="Capital" isFolder="true">
      <item id="58" name="Saint John's" isFolder="false" />
    </item>
    <item id="59" name="SurfaceAreaKm2" isFolder="true">
      <item id="60" name="442" isFolder="false" />
    </item>
    <item id="61" name="PopulationMln" isFolder="true">
      <item id="62" name="0.1" isFolder="false" />
    </item>
    <item id="63" name="President" isFolder="true">
      <item id="64" name="Gaston Browne" isFolder="false" />
    </item>
    <item id="65" name="Currency" isFolder="true">
      <item id="66" name="East Caribbean Dollar" isFolder="false" />
    </item>
  </item>

  <item id="67" name="Argentina" isFolder="true">
    <item id="68" name="Capital" isFolder="true">
      <item id="69" name="Buenos Aires" isFolder="false" />
    </item>
    <item id="70" name="SurfaceAreaKm2" isFolder="true">
      <item id="71" name="2780400" isFolder="false" />
    </item>
    <item id="72" name="PopulationMln" isFolder="true">
      <item id="73" name="45.4" isFolder="false" />
    </item>
    <item id="74" name="President" isFolder="true">
      <item id="75" name="Alberto Fernández" isFolder="false" />
    </item>
    <item id="76" name="Currency" isFolder="true">
      <item id="77" name="Argentine Peso" isFolder="false" />
    </item>
  </item>

  <item id="78" name="Armenia" isFolder="true">
    <item id="79" name="Capital" isFolder="true">
      <item id="80" name="Yerevan" isFolder="false" />
    </item>
    <item id="81" name="SurfaceAreaKm2" isFolder="true">
      <item id="82" name="29743" isFolder="false" />
    </item>
    <item id="83" name="PopulationMln" isFolder="true">
      <item id="84" name="2.96" isFolder="false" />
    </item>
    <item id="85" name="President" isFolder="true">
      <item id="86" name="Armen Sarkissian" isFolder="false" />
    </item>
    <item id="87" name="Currency" isFolder="true">
      <item id="88" name="Armenian Dram" isFolder="false" />
    </item>
  </item>

  <item id="89" name="Australia" isFolder="true">
    <item id="90" name="Capital" isFolder="true">
      <item id="91" name="Canberra" isFolder="false" />
    </item>
    <item id="92" name="SurfaceAreaKm2" isFolder="true">
      <item id="93" name="7692024" isFolder="false" />
    </item>
    <item id="94" name="PopulationMln" isFolder="true">
      <item id="95" name="25.9" isFolder="false" />
    </item>
    <item id="96" name="President" isFolder="true">
      <item id="97" name="Scott Morrison" isFolder="false" />
    </item>
    <item id="98" name="Currency" isFolder="true">
      <item id="99" name="Australian Dollar" isFolder="false" />
    </item>
  </item>

  <item id="100" name="Austria" isFolder="true">
    <item id="101" name="Capital" isFolder="true">
      <item id="102" name="Vienna" isFolder="false" />
    </item>
    <item id="103" name="SurfaceAreaKm2" isFolder="true">
      <item id="104" name="83879" isFolder="false" />
    </item>
    <item id="105" name="PopulationMln" isFolder="true">
      <item id="106" name="8.9" isFolder="false" />
    </item>
    <item id="107" name="President" isFolder="true">
      <item id="108" name="Alexander Van der Bellen" isFolder="false" />
    </item>
    <item id="109" name="Currency" isFolder="true">
      <item id="110" name="Euro" isFolder="false" />
    </item>
  </item>
</root>
""";
        }
    }
}
