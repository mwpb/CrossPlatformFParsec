namespace XamlKeypad

open System
open Xamarin.Forms
//open FParsec

type App() = 
    inherit Application()

    let mainPage = ContentPage()
    let stack = StackLayout()
    let outputLabel = Label(Text = "Initial")
    let parseButton = Button(Text = "Parse Text")
    let input = Entry(HeightRequest = 50.0,WidthRequest = 200.0)
    do parseButton.Clicked.Add(fun x -> outputLabel.Text <- sprintf "output = %A" (Parser.parseAns input.Text))
    do stack.Children.Add input
    do stack.Children.Add parseButton
    do stack.Children.Add outputLabel
    do mainPage.Content <- stack

    do base.MainPage <- mainPage