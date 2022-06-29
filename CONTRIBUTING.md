# Contributing to Arrow Utilities

Thanks for considering contributing to Arrow Utilities! 😃
<br/>There's just a few things you need to know to get started. 

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Contributing](#contributing)
  - [Purpose of ArrowUtilities](#purpose-of-arrow-utilities)
  - [What Can I Contribute?](#what-can-i-contribute)
    - [Suggestions](#suggestions)
    - [Issues and Bugs](#issues-and-bugs)
    - [Your Own Code](#your-own-code)
      - [Getting Started](#getting-started)
      - [Test Builds](#test-builds)
      - [Pull Requests](#pull-requests)
  - [Contributor's Tools](#contributors-tools)
    - [Style Guide](#style-guide)
    - [Our Discord](#our-discord)
    - [Further Reading](#further-reading)
- [Final Words](#final-words)



## Code of Conduct
The Arrow Utilities project and all of it's participants are governed by the [Code of Conduct](CODE_OF_CONDUCT.md). All participants are expected to uphold this code. 
<br/>Don't hesitate to report any and all unacceptable behavior to itshunbun@gmail.com. 

## Contributing
### Purpose of Arrow Utilities
When contributing to Arrow Utilities, it's important to know what it sets out to do. The following is a list of what exactly that is.
<br/><br/><b>✔️ Arrow Utilities DOES:</b>
- Target game development in Unity Engine.
- Provide general-purpose... 
  - static classes, 
  - structs, 
  - extension methods,
  - and syntactically sugary methods.
- Provide tools for all programming skill levels.
- Treat itself as a kitchen-sink library with variety, no outright focus.
- Give the user full control of what they're using.

<b>❌ Arrow Utilities DOESN'T:</b>
- Aim to be functional OUTSIDE of Unity Engine.
- Provide tools for SPECIFIC types of games. (example: RPG item base classes.)
- Provide background-functions that aren't within the user's direct control.

### What Can I Contribute?
There's LOTS you can do to help out the project! Whether you've used it extensively and have some criticisms you'd like fixed/changed, or you just found the project and have a great idea, take a look below at your options for contributing!

### Suggestions
Suggestions for Arrow Utilities are handled through [github's issue system](https://guides.github.com/features/issues/). We do understand that some folks might be hesitant to make an issue if they think their suggestion isn't big enough, important enough, or worthwhile. We'd never judge you like that 😤 but if you want a more "light-weight" way of suggesting to ease some of that anxiety, feel free to drop into [Our Discord]() and run it by us!

<b>Here are a few of the key components to a high-quality suggestion:</b>
- General:
  - Give a short, descriptive title. Let us know what you're suggesting without typing the whole thing twice. 
- For new features:
  - Describe the problem to solve / improvement broadly.
  - Give a more specific example of your feature being used.
  - If applicable, give a `code block` of what would be required to achieve the same effect WITHOUT your feature.
- For changing a feature:
  - List the specific feature you want to upgrade.
  - Describe what isn't currently possible / ideal with the implementation.
  - If applicable, write a `code block` to show what the implementation SHOULD look like in contrast to it's current state.

### Issues and Bugs
Issues for Arrow Utilities are also-- you guessed it-- handled through [github's issue system](http://guides.github.com/features/issues/). If you find a bug, misspelling, or anything else you believe needs fixing, write one up!

<b>Here are a few of the key components to a high-quality issue report:</b>
- Check the existing issue list! You might not be alone.
- Let us know what happened! The more details the better.
  - What was the context of the feature's usage?
  - Does it happen every time?
  - If it's a crash, include the log.
- What are the steps to reproduce the issue?
  - Make liberal use of the `code block` feature to show exactly how to make it happen again
  - If it's REALLY specific to your use-case, include whatever media you can to show it happening. (videos, images, or your own code)
- How do YOU suggest fixing it? Arrow Utils. is made by programmers FOR programmers, so feel free to chime in!
- ANY other info that you're willing to share, and you believe is important.
  - System specs, project files, Unity version, IDE, etc..  

### Your Own Code
Depending on your skill level, jumping into the code itself can be a bit of a daunting task. However, Arrow Utilities in itself was made by a beginner so there's probably plenty to fix! 😅 Let's go over some options!

#### Getting started
Step 1 for contributing is always [forking the project](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/about-forks). Basically, a 'fork' is just a copy of the whole repo, stored on your own account! This means you can alter it however you please, push changes, and mess around to your heart's content without affecting the original. 

It should be noted that you CAN STOP THERE IF YOU'D LIKE! This is especially useful if there's just a small tweak you'd like for your personal project, or if you want to make an extended version SEPARATE from the original.

#### Test-Builds
If you're making any changes to the code, testing them is important. However, given this project uses a lot of Unity-specific code, the process is a bit different than you might be used to. Here's the easiest method I've found:
1. If your IDE has a built-in terminal, you can simply type `dotnet build --configuration Release`. You can also do this in a command prompt if you navigate to the project folder first using `cd`.
2. Open the project folder and find the folders `bin -> Release -> net471` which should contain many files.
3. Select `ArrowUtilities.dll` and `ArrowUtilities.xml` ONLY. 
4. Open any Unity project. 
5. <b>BACK-UP THE PROJECT IF IT'S IMPORTANT TO YOU!!!</b>
6. Within Unity's project explorer window, create a new folder. Call it ArrowUtils, or something obvious. Certain names are reserved and will cause unwanted effects, such as "Plugins."
7. Drag and drop the two selected files from File Explorer directly into your folder in the Unity window. This should cause Unity to recompile<sup>1</sup>.

Now you should be ready to test your functions! I highly-suggest keeping Arrow Utilities itself open in another IDE window, so as you discover issues, you can add them to `//TODO:` comments. If your IDE doesn't do it automatically, remember the `using` declarations for each namespace you want to test.

<i><sup>1</sup><sub>Unity auto-generates the solution itself, so this is the best method of ensuring Unity knows what's going on, and won't throw unexpected errors.</sub></i>

#### Pull-Requests
Congratulations if you got this far! You should now have your own repository with your own version of Arrow Utilities! 🎉 If you're happy with your changes, and believe they'd benefit the main repo, you'll want to file a pull request. [You can read more about Pull Requests here.](https://docs.github.com/en/pull-requests) We'll go over the basics, but first let's make sure you're ready!

<b>Pre-Pull-Request Check List:</b>
- Do all of your changes follow [what Arrow Utilities sets out to do](#purpose-of-arrow-utilities)?
- Do all your commit descriptions, method names, class names, comments, documentation changes, and/or summaries follow the [Code of Conduct](#code-of-conduct)?
- Do all your changes stick to the [Project Style Guide](#style-guide)?
- Has all your code has been [tested in Unity](#test-builds)?

If you answered 'yes' to all of these, you're ready for a Pull-Request! [Github has a great guide for this part of the process.](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request) Make sure your request is descriptive, to the best of your ability. You can also save your request as a draft if you need more time!

Once you've submitted your Pull-Request, it's just a matter of waiting until a maintainer gets around to it. If you have it, jump into [our Discord]() and let us know you've made one. That's the best way to get an update on the status by far.

### Contributor's Tools
#### Style Guide
Every project NEEDS a style guide. This is simply a way of ensuring no huge shifts in stylization make the code unreadable. We'll make this short and sweet. Here's a real code snippet from the project:
```csharp
/// <summary>
///     <para>
///         Returns an integer between 1 and the number of sides provided. <br />
///         <b>Note: values less than '1' will always return '-1.'</b>
///     </para>
/// </summary>
/// <param name="sides">How many sides the die rolled has.</param>
/// <returns></returns>
public static int DiceRoll(int sides) {
    if (sides >= 1) return UnityEngine.Random.Range(0, sides) + 1;
    return -1;
}
```
Here's the takeaway from that snippet:
- XML summaries are used for all public classes and members. 
  - `<b>Bold Text</b>` is used in summaries for notes and warnings.
  - `<param>` names and descriptions are specified
  - `<returns>` is specified, but may be left blank if the method is simple enough for the summary to be the same thing.
- Method names are written in `PascalCase`
- Passed-in variables are written in `camelCase`
- In-line `return` may be used for methods with a condition-or-default format

Here's another snippet, this time not from the project, but created here for demonstration.
```csharp
///<summary>
///<para>Simple demonstration class</para>
///</summary>
public static class MyClass {
  ///<summary>
  ///<para>Integer property for demonstration purposes</para>
  ///</summary>
  public static int MyInt {get; set;}
  private static int _mySecretInt, _myOtherSecretInt;
  private static readonly int MyReadOnlyInt = 0;
  
  private static void SetAllWritableIntsToZero(){
    var zero = 0;
    MyInt = zero;
    _mySecretInt = zero;
    _myOtherSecretInt = zero;
  }
}
```
Here's the takeaway from that snippet:
- XML summaries that are short, with no bold text or line breaks may use in-line `<para>` tags.
- All classes use `PascalCase`.
- Multiple in-line variable declarations are allowed, purely by preference.
- Public properties are written in `PascalCase`<sup>1</sup>.
- Private variables are written in `_camelCase`.
- Readonly variables, public or private, are written in `PascalCase`.
- Even private methods are written in `PascalCase`.
- Method-scoped variables are written in `camelCase`
- The `var` keyword is used for method-scoped variables, where possible.
- Member names aim to be [self-documenting](https://www.youtube.com/watch?v=cmh5WzEqbDI), so `//comments` are as scarce as possible. 

That should cover it! ArrowUtilities is written in C# 4.0, (for compatibility reasons) so things like LAMBDA method expressions aren't even available to worry about. (As helpful as they would be... 😢)

Just about everything else is up to your preference. If the rules listed above made you cringe, file an issue. As a beginner programmer, I'd be glad to hear your criticisms/suggestions for how to alter it. I'll gladly reformat the project in its entirety.

<i><sup>1</sup><sub>The SerializableVector structs break this rule. It's more important for them to match the original Vector structs. Sorry for the inconsistency.</sub></i>

#### Our Discord
As of the launch of this project, we're launching our Discord server! Among other things, it will be the best place to get in touch with each other regarding the project and any concerns that arise because of it. 

Join here: <strike>[Click here to join!]</strike> (Coming Soon!)

#### Further Reading
If you're new to Open Source projects, (much like myself) I advise reading some of the fantastic documentation that GitHub themselves have created. <b>Look for the 'Collaborative Coding' section.</b> It will elevate your understanding of the process ten-fold in an hour of reading, I promise. [Here's a link!](https://docs.github.com/en) 

### Final Words
Phew that was a lot of writing! 😅

I'd just like to thank you again for even considering contributing to Arrow Utilities. As I've mentioned probably too-many times, I'm still a novice when it comes to code, open-source, and especially Class Library packages like this. So to collaborate with other programmers of all skill-levels is something that will be extremely beneficial in my journey toward "good" programmer! 

-Andrew Arrow




