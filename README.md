# Observer Pattern

## Description

The **Observer Pattern** is a behavioral design pattern that defines a one-to-many dependency relationship between objects. When the state of the subject (publisher) changes, all its dependent observers (subscribers) are automatically notified and updated. This pattern is particularly useful in scenarios such as event handling, notifications, and real-time data updates like stock price tracking.

## Components

1. **Subject**: Maintains a list of observers and notifies them when its state changes.
2. **Observer**: Defines an interface for objects that should be notified of changes in the subject.
3. **Concrete Subject**: A specific implementation of the subject that maintains state and triggers notifications.
4. **Concrete Observer**: A specific implementation of the observer that reacts to state changes in the subject.

## Structure

- **IObserver Interface**: The observer interface with a `Notify()` method to receive updates.
- **StockInfo Class**: Represents the stock information, containing the stock symbol and price.
- **StockSubject Class**: The base class for subjects, responsible for managing observers and updating them.
- **ConcreteStockSubjectGoogle Class**: A specific subject that represents stock information for Google.
- **ConcreteObserver Class**: Represents an observer that reacts to updates from the stock subject.

## Example

In this example, the `ConcreteStockSubjectGoogle` represents a stock subject (Google stock) whose price can change. Observers (e.g., `ConcreteObserver`) subscribe to this subject and are notified when the stock price changes.

### Steps to Use:

1. Create a `ConcreteStockSubjectGoogle` object (subject).
2. Add `ConcreteObserver` objects (observers) to the subject.
3. Call `UpdatePrice()` on the subject to trigger updates and notify observers.

## Code Example

```csharp
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnObserver_Click(object sender, EventArgs e)
    {
        ConcreteStockSubjectGoogle csgoog = new ConcreteStockSubjectGoogle();
        ConcreteObserver co1 = new ConcreteObserver("Bill");
        csgoog.AddObserver(co1);
        ConcreteObserver co2 = new ConcreteObserver("Sally");
        csgoog.AddObserver(co2);
        csgoog.UpdatePrice(7.50); // Updates the stock price and notifies observers
    }
}
```

### Output

When the button is clicked, observers receive notifications with the updated stock price:

- "Notification sent to : Bill
  Goog : 592.50"
- "Notification sent to : Sally
  Goog : 592.50"

## Advantages

- **Loose Coupling**: The subject and observers are loosely coupled, meaning changes to the subject don't require changes to the observers.
- **Dynamic Updates**: Observers are automatically notified of state changes without needing to poll the subject.
- **Flexible**: New observers can be added or removed dynamically.

## Use Cases

- Stock price monitoring systems
- Event-driven systems
- Real-time notifications and alert systems

## Conclusion

The Observer Pattern helps in decoupling the code by ensuring that the subject doesn't need to know the specifics of its observers. Observers just register themselves with the subject and get notified when there is a change in the subject’s state.
