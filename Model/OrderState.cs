namespace BlazingPizza;
using System;
using System.Collections.Generic;
using System.Linq;

public class OrderState
{
    public bool ShowingConfigureDialog { get; private set; }
    public Pizza ConfiguringPizza { get; private set; }
    public Order Order { get; private set; } = new Order();
    // --- 2. AÑADE ESTAS DOS LÍNEAS ---
    public event Action OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();
    // ---------------------------------

    public void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        ConfiguringPizza = new Pizza()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>(),
        };

        ShowingConfigureDialog = true;
        NotifyStateChanged(); // <-- 3. AÑADE ESTA LLAMADA
    }

    public void CancelConfigurePizzaDialog()
    {
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
        NotifyStateChanged(); // <-- 3. AÑADE ESTA LLAMADA
    }

    public void ConfirmConfigurePizzaDialog()
    {
        Order.Pizzas.Add(ConfiguringPizza);
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
        NotifyStateChanged(); // <-- 3. AÑADE ESTA LLAMADA
    }

    public void RemoveConfiguredPizza(Pizza pizza)
    {
        Order.Pizzas.Remove(pizza);
        NotifyStateChanged(); // <-- 3. AÑADE ESTA LLAMADA
    }
    
    public void ResetOrder()
    {
        Order = new Order();
        NotifyStateChanged(); // <-- 3. AÑADE ESTA LLAMADA
    }
}
