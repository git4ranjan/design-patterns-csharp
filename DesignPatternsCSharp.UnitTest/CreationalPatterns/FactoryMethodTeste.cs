using DesignPatternsCSharp.CreationalPatterns.FactoryMethod;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns
{
    public class FactoryMethodTeste
    {
        [Fact]
        public void DeveCriarOsIngredientesPãoSalsichaPãoQuandoOObjetoCachorroQuenteÉCriado()
        {
            var ingredientesDoCachorroQuente = new List<Ingrediente>()
            {
                new Pão(),
                new Salsicha(),
                new BatataPalha(),
                new Pão()
            };

            var cachorroQuente = new CachorroQuente();

            cachorroQuente.Ingredientes.ShouldBeEquivalentTo(ingredientesDoCachorroQuente);
        }

        [Fact]
        public void DeveCriarOsIngredientesPãoQueijoPresuntoTomatePãoQuandoOObjetoBauruÉCriado()
        {
            var ingredientesDoBauru = new List<Ingrediente>()
            {
                new Pão(),
                new Queijo(),
                new Presunto(),
                new Tomate(),
                new Pão()
            };

            var bauru = new Bauru();
            
            bauru.Ingredientes.ShouldBeEquivalentTo(ingredientesDoBauru);
        }
    }
}