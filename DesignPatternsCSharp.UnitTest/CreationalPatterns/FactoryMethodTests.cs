using DesignPatternsCSharp.CreationalPatterns.FactoryMethod;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void ShouldCreateHotDogIngredientsWhenHotDogIsInstantiated()
        {
            var hotDogIngredients = new List<Ingredient>()
            {
                new Bread(),
                new Sausage(),
                new PotatoSticks(),
                new Bread()
            };
            var hotDog = new HotDog();

            hotDog.Ingredients[0].Should().BeOfType(hotDogIngredients[0].GetType());
            hotDog.Ingredients[1].Should().BeOfType(hotDogIngredients[1].GetType());
            hotDog.Ingredients[2].Should().BeOfType(hotDogIngredients[2].GetType());
            hotDog.Ingredients[3].Should().BeOfType(hotDogIngredients[3].GetType());
        }

        [Test]
        public void ShouldCreateBrazilianBauruIngredientsWhenBrazilianBauruIsInstantiated()
        {
            var brazilianBauruIngredients = new List<Ingredient>()
            {
                new Bread(),
                new Cheese(),
                new Ham(),
                new Tomato(),
                new Bread()
            };
            var brazilianBauru = new BrazilianBauru();

            brazilianBauru.Ingredients[0].Should().BeOfType(brazilianBauruIngredients[0].GetType());
            brazilianBauru.Ingredients[1].Should().BeOfType(brazilianBauruIngredients[1].GetType());
            brazilianBauru.Ingredients[2].Should().BeOfType(brazilianBauruIngredients[2].GetType());
            brazilianBauru.Ingredients[3].Should().BeOfType(brazilianBauruIngredients[3].GetType());
            brazilianBauru.Ingredients[4].Should().BeOfType(brazilianBauruIngredients[4].GetType());
        }
    }
}
