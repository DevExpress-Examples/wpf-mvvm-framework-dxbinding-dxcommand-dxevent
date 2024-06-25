<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658217/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T370796)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

#  WPF MVVM Framework - DXBinding, DXCommand, and DXEvent Extensions

This example demonstrates use cases of the [DXBinding](https://docs.devexpress.com/WPF/115771/mvvm-framework/dxbinding/dxbinding), [DXCommand](https://docs.devexpress.com/WPF/115776/mvvm-framework/dxbinding/dxcommand), and [DXEvent](https://docs.devexpress.com/WPF/115778/mvvm-framework/dxbinding/dxevent) markup extensions.

![image](https://user-images.githubusercontent.com/65009440/220123866-22f8342d-6790-4e10-a9f3-e168ef6c6541.png)

* The [DXBinding](https://docs.devexpress.com/WPF/115771/mvvm-framework/dxbinding/dxbinding) allows you to use expressions inside binding paths.

  ```xaml
  Text="{DXBinding 'StringValue+DoubleValue.ToString()', Mode=OneWay}"
  
  ```

* With the [DXCommand](https://docs.devexpress.com/WPF/115776/mvvm-framework/dxbinding/dxcommand), you can bind a command property and define methods to call right in xaml.

  ```xaml
  Command="{DXCommand Execute='$MessageBox.Show(@e(message).Text, @e(title).Text)',
                      CanExecute='@e(isEnabled).IsChecked'}"
  ```
  
* The [DXEvent](https://docs.devexpress.com/WPF/115778/mvvm-framework/dxbinding/dxevent) allows you to bind an event to methods.

  ```xaml
  Click="{DXEvent '$MessageBox.Show($string.Format(@r(clickBindingStringFormat), @r(clickBinding)), Title)'}"
  ```

## Files to Review

* [BasicExpressionsView.xaml](./CS/DXBindingExample/View/BasicExpressionsView.xaml) (VB: [BasicExpressionsView.xaml](./VB/DXBindingExample/View/BasicExpressionsView.xaml))
* [RelativeSourcesView.xaml](./CS/DXBindingExample/View/RelativeSourcesView.xaml) (VB: [RelativeSourcesView.xaml](./VB/DXBindingExample/View/RelativeSourcesView.xaml))
* [StaticPropertiesView.xaml](./CS/DXBindingExample/View/StaticPropertiesView.xaml) (VB: [StaticPropertiesView.xaml](./VB/DXBindingExample/View/StaticPropertiesView.xaml))
* [BindingToMethodView.xaml](./CS/DXBindingExample/View/BindingToMethodView.xaml) (VB: [BindingToMethodView.xaml](./VB/DXBindingExample/View/BindingToMethodView.xaml))
* [TwoWayView.xaml](./CS/DXBindingExample/View/TwoWayView.xaml) (VB: [TwoWayView.xaml](./VB/DXBindingExample/View/TwoWayView.xaml))
* [CommandView.xaml](./CS/DXBindingExample/View/CommandView.xaml) (VB: [CommandView.xaml](./VB/DXBindingExample/View/CommandView.xaml))
* [EventView.xaml](./CS/DXBindingExample/View/EventView.xaml) (VB: [EventView.xaml](./VB/DXBindingExample/View/EventView.xaml))

## Documentation

* [DXBinding](https://docs.devexpress.com/WPF/115771/mvvm-framework/dxbinding/dxbinding)
* [DXCommand](https://docs.devexpress.com/WPF/115776/mvvm-framework/dxbinding/dxcommand)
* [DXEvent](https://docs.devexpress.com/WPF/115778/mvvm-framework/dxbinding/dxevent)
* [Language Specification and Limitations](https://docs.devexpress.com/WPF/115777/mvvm-framework/dxbinding/language-specification)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-dxbinding-dxcommand-dxevent&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-dxbinding-dxcommand-dxevent&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
