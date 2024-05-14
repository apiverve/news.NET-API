News API
============

News API is a simple tool for scraping news data. It returns the news title, description, and more.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [News API](https://apiverve.com/marketplace/api/news)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.News
```

Using the Package Manager:
```
nuget install APIVerve.API.News
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.News
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.News".
5. Click on the APIVerve.API.News package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the news API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The News API documentation is found here: [https://docs.apiverve.com/api/news](https://docs.apiverve.com/api/news).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
News API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new NewsAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new QueryOptions {
  category = "technology"
};
```

###### Simple Request

```
var response = apiClient.execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    Console.WriteLine(response);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "date": "2024-05-13",
    "category": "technology",
    "articleCount": 60,
    "articles": [
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Art Market Seeks Its Footing After Stumbling Sales and a Hack at Christie’s",
        "pubDate": "Mon, 13 May 2024 01:41:38 +0000",
        "description": "Declining sales and a cyberattack ignite new worries at spring art auctions.",
        "link": "https://www.nytimes.com/2024/05/12/arts/design/will-auctions-revive-art-market.html"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Quordle today – hints and answers for Monday, May 13 (game #840) ",
        "pubDate": "Sun, 12 May 2024 23:15:00 +0000",
        "description": "Looking for Quordle clues? We can help. Plus get the answers to Quordle today and past solutions.",
        "link": "https://www.techradar.com/computing/websites-apps/quordle-today-answers-clues-13-may-2024"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " NYT Strands today — hints, answers and spangram for Monday, May 13 (game #71) ",
        "pubDate": "Sun, 12 May 2024 23:10:00 +0000",
        "description": "Looking for NYT Strands answers and hints? Here's all you need to know to solve today's game, including the spangram.",
        "link": "https://www.techradar.com/computing/websites-apps/nyt-strands-today-answers-hints-13-may-2024"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "How Airlines Are Using AI to Make Flying Easier",
        "pubDate": "Sun, 12 May 2024 22:09:56 +0000",
        "description": "Airlines are using artificial intelligence to save fuel, keep customers informed and hold connecting flights for delayed passengers. Here’s what to expect.",
        "link": "https://www.nytimes.com/2024/05/10/travel/airlines-artificial-intelligence.html"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Solar Storms are disrupting farmer GPS systems during critical planting time",
        "pubDate": "2024-05-12T18:05:18Z",
        "description": "Image: John Deere          The solar storms that have been wowing people with the Northern Lights across the United States the last two nights have also been disrupting GPS satellites, crippling some Midwest farmers’ operations, reports 404 Media. The issues have forced many to stop planting just as a crucial planting deadline for corn farmers approaches. The storms reportedly knocked “some GPS systems” offline temporarily, which messed with the accuracy of “Real-Time Kinematic” (RTK) systems. Tractors from John Deere and other brands use RTK for “centimeter-level positional accuracy” when carrying out farming work like crop-planting or fertilizing, 404 Media writes.    The “extremely compromised” systems caused “drastic shifts in the field and even some heading... Continue reading…",
        "link": "https://www.theverge.com/2024/5/12/24154779/solar-storms-farmer-gps-john-deer"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Elon Musk’s Diplomacy: Woo Right-Wing World Leaders. Then Benefit.",
        "pubDate": "Sun, 12 May 2024 15:33:07 +0000",
        "description": "Mr. Musk has built a constellation of like-minded heads of state — including Argentina’s Javier Milei and India’s Narendra Modi — to push his own politics and expand his business empire.",
        "link": "https://www.nytimes.com/2024/05/12/technology/elon-musk-world-leaders.html"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "The Gamma app brings PS1 emulation to the iPhone",
        "pubDate": "2024-05-12T14:52:48Z",
        "description": "Time for some Abe’s Oddysee! | Screenshot: Gamma          iPhone users without a penchant for jailbreaking can finally enjoy the blocky polygons and shifty textures of the original PlayStation with Gamma, a free PS1 emulator that hit the iOS App Store last night. Gamma comes courtesy of developer ZodTTD, which has been creating emulators for the iPhone since the earliest days of third-party iOS apps. The app has both iPhone and iPad versions with support for Bluetooth controllers and keyboards, as well as customizable on-screen controller skins. It uses Google Drive and Dropbox syncing for backing up your game files and save states (those are the snapshots you can save at any time and reload, a little like pausing your game — great for old-school games that don’t let you save any time you... Continue reading…",
        "link": "https://www.theverge.com/2024/5/12/24154703/gamma-ps1-emulator-iphone-ios-apple-app-store"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "The DJI Pocket 3 is almost everything I wanted my iPhone camera to be",
        "pubDate": "2024-05-12T14:30:00Z",
        "description": "Despite its name, the Pocket 3 isn’t exactly comfortable to stuff in tighter pockets. | Photo by Quentyn Kennemer / The Verge          I can’t think of anything permeating mainstream camera culture as aggressively as the DJI Osmo Pocket 3. The Fujifilm X100VI has stolen some of its thunder among film simulation enthusiasts, but DJI’s still having somewhat of a cultural moment on YouTube, Instagram, and the troubled TikTok by spurring all sorts of creator glee. Of course, the camera buffs are all over it, but serious and casual creators from other genres have paused their usual programming to rave about how it transcends amateur vlogging pursuits, whether you’re filming a wedding or self-shooting a scene for a Sundance-hopeful short film. Some of us at The Verge are excited, too: Vjeran liked it enough to call it his favorite gadget of 2023, and Sean just bought one... Continue reading…",
        "link": "https://www.theverge.com/24152949/dji-osmo-pocket-3-opinion"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Patient Dies Weeks After Kidney Transplant From Genetically Modified Pig",
        "pubDate": "Sun, 12 May 2024 14:21:55 +0000",
        "description": "Richard Slayman received the historic procedure in March. The hospital said it had “no indication” his death was related to the transplant.",
        "link": "https://www.nytimes.com/2024/05/12/health/richard-slayman-death-pig-kidney-transplant.html"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Buy Microsoft Office Pro 2021 and Windows 11 Pro bundled for $70 right now: Last chance",
        "pubDate": "Sun, 12 May 2024 14:00:16 +0000",
        "description": "This lifetime license bundle deal gives you access to the entire Microsoft Office Pro 2021 suite and Windows 11 Pro for over 80% off.",
        "link": "https://www.zdnet.com/article/microsoft-office-pro-2021-windows-11-pro-deal/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Hisense U8N TV Review: Loaded Package, Shades Required",
        "pubDate": "Sun, 12 May 2024 14:00:00 +0000",
        "description": "Hisense’s flagship TV brings over-the-top brightness but still comes out a winner.",
        "link": "https://www.wired.com/review/hisense-u8n/"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "The rise of the audio-only video game",
        "pubDate": "2024-05-12T14:00:00Z",
        "description": "Image: Samar Haddad / The Verge          Not all video games need video. Over the years, games that exist only in audio have taken players into entirely new worlds in which there’s nothing to see and still everything to do. These games have huge accessibility implications, allowing people who can’t see to play an equally fun, equally immersive game with their other senses. And when all you have is sound, there’s actually even more you can do to make your game great. On this episode of The Vergecast, we explore the history of audio-only games with Paul Bennun, who has been in this space longer than most. Years ago, Bennun and his team at Somethin’ Else made a series of games called Papa Sangre that were among the most innovative and most popular games of their kind. He explains... Continue reading…",
        "link": "https://www.theverge.com/24153919/audio-games-papa-sangre-vergecast"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Gazelle Eclipse Review: A Luxury Dutch Electric Bike",
        "pubDate": "Sun, 12 May 2024 13:30:00 +0000",
        "description": "Gazelle’s latest long-range electric bike has a mind-boggling Bosch smart system and is extremely comfortable, smart, and pricey.",
        "link": "https://www.wired.com/review/gazelle-eclipse/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Reading Has Hurt Me for Years. With a Tablet Holder, It Doesn't",
        "pubDate": "Sun, 12 May 2024 13:00:00 +0000",
        "description": "Cysts in both wrists made reading a literal pain. But Lamicall’s Tablet Holder takes that pain away by holding up my Kindle for me.",
        "link": "https://www.wired.com/story/lamicall-kindle-holder-rave/"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Get a Costco membership for $20: Last chance",
        "pubDate": "Sun, 12 May 2024 12:00:30 +0000",
        "description": "This Costco deal gives you a $40 gift card free, effectively lowering the price of an annual Gold Star Membership to just $20. (I even bought it myself.) Hurry -- it ends tonight.",
        "link": "https://www.zdnet.com/home-and-office/costco-membership-deal/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Latest iPad launch was marred by one big mistake. Here's how Apple can fix it",
        "pubDate": "Sun, 12 May 2024 12:00:19 +0000",
        "description": "When the unveiling of your new iPads distresses Hugh Grant, you have a problem. What if Apple actively, cleverly - even happily - sold us on the benefits of thin?",
        "link": "https://www.zdnet.com/article/latest-ipad-launch-marred-by-one-big-mistake-heres-how-apple-can-fix-it/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "The Best Sheets (2024): Linen, Percale, and Budget Bedding",
        "pubDate": "Sun, 12 May 2024 12:00:00 +0000",
        "description": "Which material should you buy? Percale or linen? We tested dozens of sheets to find our favorites and break it all down.",
        "link": "https://www.wired.com/story/best-bedsheets/"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "The new iPad Pro looks like a winner",
        "pubDate": "2024-05-12T12:00:00Z",
        "description": "Image: David Pierce / The Verge          Hi, friends! Welcome to Installer No. 37, your guide to the best and Verge-iest stuff in the world. (If you’re new here, welcome, send me links, and also, you can read all the old editions at the Installer homepage.)  This week, I’ve been writing about iPads and LinkedIn games, reading about auto shows and typewriters and treasure hunters, watching Everybody’s in LA and Sugar, looking for reasons to buy Yeti’s new French press even though I definitely don’t need more coffee gear, following almost all of Jerry Saltz’s favorite Instagram accounts, testing Capacities and Heptabase for all my note-taking needs and Plinky for all my link-saving, and playing a lot of Blind Drive. I also have for you a thoroughly impressive new iPad, a clever... Continue reading…",
        "link": "https://www.theverge.com/24153472/apple-ipad-pro-animal-well-final-cut-camera-installer-newsletter"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "One of the best Android watches I've tested is not made by Google or Samsung",
        "pubDate": "Sun, 12 May 2024 11:00:25 +0000",
        "description": "Most smartwatches last a day or two between charging, but Mobvoi's TicWatch Pro 5 Enduro doubles that - and for a reasonable price.",
        "link": "https://www.zdnet.com/article/one-of-the-best-android-watches-ive-tested-is-not-made-by-google-or-samsung/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Apple iPad Air (2024) vs. iPad Air (2022): Which model should you buy?",
        "pubDate": "Sun, 12 May 2024 11:00:22 +0000",
        "description": "Apple's 2024 iPad Air is here with a larger display option and upgraded specs. Here's how it stacks up against the previous model.",
        "link": "https://www.zdnet.com/article/apple-ipad-air-2024-vs-ipad-air-2022/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Get Microsoft Project 2021 Pro or Visio 2021 for $30",
        "pubDate": "Sun, 12 May 2024 11:00:16 +0000",
        "description": "Microsoft's project management solutions feature timesheet support, org charts, and more to help you stay organized -- and they're 88% off right now.",
        "link": "https://www.zdnet.com/article/microsoft-project-pro-deal-microsoft-visio-deal/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Comcast unveils contract-free internet plans, starting at $30 a month - is there a catch?",
        "pubDate": "Sun, 12 May 2024 10:30:16 +0000",
        "description": "If you're looking to save money on your internet and phone bills, Comcast has a surprisingly affordable deal for you.",
        "link": "https://www.zdnet.com/home-and-office/networking/comcast-unveils-contract-free-internet-plans-starting-at-30-a-month-is-there-a-catch/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "The M4 iPad Pro's true potential will be realized at WWDC, and AI will have a lot to do with it",
        "pubDate": "Sun, 12 May 2024 10:00:16 +0000",
        "description": "Apple's challenge will be aligning breakthrough hardware, like the AI-powered M4 chip, with cutting-edge software.",
        "link": "https://www.zdnet.com/article/the-m4-ipad-pros-true-potential-will-be-realized-at-wwdc-and-ai-will-have-a-lot-to-do-with-it/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "An Innovative EV Motor Used by Lamborghini, McLaren, and Ferrari Is Being Mass-Produced by Mercedes",
        "pubDate": "Sun, 12 May 2024 10:00:00 +0000",
        "description": "Compared to the usual EV power plants, axial-flux motors are smaller and lighter, and have more torque. But they're hard to make at scale. Now Mercedes is bringing them to the masses.",
        "link": "https://www.wired.com/story/yasa-motors-mercedes-axial-flux-2024/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "NASA’s Quest to Touch the Sun",
        "pubDate": "Sun, 12 May 2024 06:00:00 +0000",
        "description": "The outer layers of the sun’s atmosphere are a blistering million degrees hotter than its surface. NASA sent a probe to find out why—by getting closer to the star than ever before.",
        "link": "https://www.wired.com/story/parker-solar-probe-sun-solar-energy-magnetism-wind/"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Quordle today – hints and answers for Sunday, May 12 (game #839) ",
        "pubDate": "Sat, 11 May 2024 23:15:00 +0000",
        "description": "Looking for Quordle clues? We can help. Plus get the answers to Quordle today and past solutions.",
        "link": "https://www.techradar.com/computing/websites-apps/quordle-today-answers-clues-12-may-2024"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " NYT Strands today — hints, answers and spangram for Sunday, May 12 (game #70) ",
        "pubDate": "Sat, 11 May 2024 23:10:00 +0000",
        "description": "Looking for NYT Strands answers and hints? Here's all you need to know to solve today's game, including the spangram.",
        "link": "https://www.techradar.com/computing/websites-apps/nyt-strands-today-answers-hints-12-may-2024"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Steam, Epic and GMG are canceling Ghost of Tsushima PC pre-orders in non-PSN countries",
        "pubDate": "2024-05-11T22:12:28Z",
        "description": "Screenshot: Ghost of Tsushima          Steam, Epic, and Green Man Gaming are reportedly canceling and refunding preorders of the PC port of Ghost of Tsushima for buyers who live in over 170 countries without PlayStation Network access, reports Eurogamer. That’s despite the fact that arguably the most important part of the game is still playable without PlayStation Network account linking. The news comes after Valve abruptly delisted the game in those countries yesterday.  Ghost of Tsushima only requires PSN account linking for its Legends multiplayer mode, a requirement the single player campaign is exempt from, the game’s developer went out of its way to say in a recent post. Steam, Green Man Gaming, and Epic Games Store each had disclaimers noting the same thing. In theory,... Continue reading…",
        "link": "https://www.theverge.com/2024/5/11/24154412/steam-refunding-ghost-of-tsushima-preorders-psn-network-unavailable"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "OpenAI could debut a multimodal AI digital assistant soon",
        "pubDate": "2024-05-11T18:20:39Z",
        "description": "Illustration: The Verge          OpenAI has been showing some of its customers a new multimodal AI model that can both talk to you and recognize objects, according to a new report from The Information. Citing unnamed sources who’ve seen it, the outlet says this could be part of what the company plans to show on Monday. The new model reportedly offers faster, more accurate interpretation of images and audio than what its existing separate transcription and text-to-speech models can do. It would apparently be able to help customer service agents “better understand the intonation of callers’ voices or whether they’re being sarcastic,” and “theoretically,” the model can help students with math or translate real-world signs, writes The Information. The outlet’s sources say... Continue reading…",
        "link": "https://www.theverge.com/2024/5/11/24154307/openai-multimodal-digital-assistant-chatgpt-phone-calls"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "The Verge’s 2024 Mother’s Day gift guide",
        "pubDate": "2024-05-11T16:05:16Z",
        "description": "Illustration by Manon Louart for The Verge          \t\t  We found a collection of unique gift ideas that go beyond the flowers and chocolates that typically rule the day. Continue reading…",
        "link": "https://www.theverge.com/24115101/best-mothers-day-gift-ideas-2024-mom-tech-gadgets"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "iFixit’s Pro Tech Toolkit is on sale for just $60",
        "pubDate": "2024-05-11T15:37:46Z",
        "description": "iFixit’s step-up toolkit has all sorts of bits and bobs, all of which slot nicely in the case and included fabric roll. | Image: iFixit          The right-to-repair movement has logged some serious wins over the past several years, with states like California, New York, and Minnesota having recently passed laws that make it easier for consumers to repair their own devices. But being able to obtain parts and manuals is only part of the process — you also need the tools. Luckily, iFixit’s Pro Tech Toolkit is on sale at Amazon, Best Buy, and iFixit for $59.96 ($15 off), matching the lowest price we’ve seen on the versatile tool set.   Chances are you know iFixit for its in-depth teardowns of various gadgets and gizmos, including iPhone 15 Pro Max, headsets like the Apple Vision Pro, and the confounding mess that is the Humane AI Pin (sorry not sorry). That said, the company also... Continue reading…",
        "link": "https://www.theverge.com/2024/5/11/24153242/ifixit-pro-tech-toolkit-sharge-retro-67-charger-deal-sale"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Google I/O 2024 will be all about AI again",
        "pubDate": "2024-05-11T15:16:00Z",
        "description": "Image: Google          Google is preparing to hold its annual Google I/O developer conference next week, and naturally, it will be all about AI. The company has made no secret of that. Since last year’s I/O, it has debuted Gemini, its new, more powerful model meant to compete with OpenAI’s ChatGPT, and has been deep in testing new features for Search, Google Maps, and Android. Expect to hear a lot about that stuff this year. When Google I/O will happen and where you can watch Google I/O kicks off on Tuesday, May 14th at 10AM PT / 1PM ET with a keynote talk. You can catch that on Google’s site or its YouTube channel, via the livestream link that’s also embedded at the top of this page. (There’s also a version with an American Sign Language interpreter.) Set a... Continue reading…",
        "link": "https://www.theverge.com/2024/5/11/24154219/google-i-o-2024-what-to-expect-where-watch-livestream-ai-android-search-gemini"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Upgrade to Windows 11 Pro for $40 right now",
        "pubDate": "Sat, 11 May 2024 15:00:24 +0000",
        "description": "Windows 11 Pro can give you more productivity features that will help you get things done.",
        "link": "https://www.zdnet.com/article/windows-11-deal/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "3 Best Smart Scales (2024): Luxe, Budget, and All App-Connected",
        "pubDate": "Sat, 11 May 2024 15:00:00 +0000",
        "description": "If you’re ready to start tracking your weight, BMI, and other critical health data on your phone, we’ve weighed in on some great options.",
        "link": "https://www.wired.com/gallery/best-smart-scales/"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "The best rugged tablets of 2024: Expert tested and reviewed",
        "pubDate": "Sat, 11 May 2024 14:00:19 +0000",
        "description": "We went hands-on with the best rugged tablets that were tested against US military standards to survive drops, shocks, dirt, and moisture.",
        "link": "https://www.zdnet.com/article/best-rugged-tablet/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Apollo Go (2024) Review: A Great Commuter Scooter",
        "pubDate": "Sat, 11 May 2024 14:00:00 +0000",
        "description": "Apollo’s midrange electric scooter has all the bells and whistles you’d want in a reasonable 46-pound package.",
        "link": "https://www.wired.com/review/apollo-go-2024/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Stack Overflow Users Are Revolting Against an OpenAI Deal",
        "pubDate": "Sat, 11 May 2024 13:30:00 +0000",
        "description": "Members of the software developer community have reported deleting or altering their posts to prevent them from being used by OpenAI.",
        "link": "https://www.wired.com/story/stack-overflow-users-openai-revolt/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Beats Solo 4 Review: Minimal Features, Maximized Sound",
        "pubDate": "Sat, 11 May 2024 13:00:00 +0000",
        "description": "Beats’ latest on-ear headphones lack noise canceling and auto pause, but they sound fantastic.",
        "link": "https://www.wired.com/review/beats-solo-4/"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " OpenAI has big news to share on May 13 – but it's not announcing a search engine ",
        "pubDate": "Sat, 11 May 2024 10:30:32 +0000",
        "description": "OpenAI will be sharing some news on Monday, but the rumored ChatGPT search engine won't appear.",
        "link": "https://www.techradar.com/computing/artificial-intelligence/openai-has-big-news-to-share-on-may-13-but-its-not-announcing-a-search-engine"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "FIN7 Hacker Group Leverages Malicious Google Ads to Deliver NetSupport RAT",
        "pubDate": "Sat, 11 May 2024 12:59:00 +0530",
        "description": "The financially motivated threat actor known as FIN7 has been observed leveraging malicious Google ads spoofing legitimate brands as a means to deliver MSIX installers that culminate in the deployment of NetSupport RAT. \"The threat actors used malicious websites to impersonate well-known brands, including AnyDesk, WinSCP, BlackRock, Asana, Concur, The Wall",
        "link": "https://thehackernews.com/2024/05/fin7-hacker-group-leverages-malicious.html"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Quordle today – hints and answers for Saturday, May 11 (game #838) ",
        "pubDate": "Fri, 10 May 2024 23:15:00 +0000",
        "description": "Looking for Quordle clues? We can help. Plus get the answers to Quordle today and past solutions.",
        "link": "https://www.techradar.com/computing/websites-apps/quordle-today-answers-clues-11-may-2024"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " NYT Strands today — hints, answers and spangram for Saturday, May 11 (game #69) ",
        "pubDate": "Fri, 10 May 2024 23:10:00 +0000",
        "description": "Looking for NYT Strands answers and hints? Here's all you need to know to solve today's game, including the spangram.",
        "link": "https://www.techradar.com/computing/websites-apps/nyt-strands-today-answers-hints-11-may-2024"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Android users may soon have an easier, faster way to magnify on-screen elements ",
        "pubDate": "Fri, 10 May 2024 23:00:32 +0000",
        "description": "Android 15's potential fourth zoom-in method could be the solution users have been waiting for, as the others aren't great.",
        "link": "https://www.techradar.com/computing/software/android-users-may-soon-have-an-easier-faster-way-to-magnify-on-screen-elements"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Apple Will Revamp Siri to Catch Up to Its Chatbot Competitors",
        "pubDate": "Fri, 10 May 2024 20:52:37 +0000",
        "description": "Apple plans to announce that it will bring generative A.I. to iPhones after the company’s most significant reorganization in a decade.",
        "link": "https://www.nytimes.com/2024/05/10/business/apple-siri-ai-chatgpt.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "California Will Add a Fixed Charge to Electric Bills and Reduce Rates",
        "pubDate": "Fri, 10 May 2024 18:22:27 +0000",
        "description": "Officials said the decision would lower bills and encourage people to use cars and appliances that did not use fossil fuels, but some experts said it would discourage energy efficiency.",
        "link": "https://www.nytimes.com/2024/05/10/business/energy-environment/california-electric-bills-fixed-charge.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Christie’s Website Is Brought Down by Hackers Days Before $840 Million Auctions",
        "pubDate": "Fri, 10 May 2024 16:32:22 +0000",
        "description": "The auctioneer’s website was taken offline on Thursday evening and remained down on Friday, days before its spring auctions were set to begin.",
        "link": "https://www.nytimes.com/2024/05/10/arts/design/christies-cyberattack-website.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "North Korean Hackers Deploy New Golang Malware 'Durian' Against Crypto Firms",
        "pubDate": "Fri, 10 May 2024 20:24:00 +0530",
        "description": "The North Korean threat actor tracked as Kimsuky has been observed deploying a previously undocumented Golang-based malware dubbed Durian as part of highly-targeted cyber attacks aimed at two South Korean cryptocurrency firms. \"Durian boasts comprehensive backdoor functionality, enabling the execution of delivered commands, additional file downloads, and exfiltration of files,\"",
        "link": "https://thehackernews.com/2024/05/north-korean-hackers-deploy-new-golang.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "CensysGPT: AI-Powered Threat Hunting for Cybersecurity Pros (Webinar)",
        "pubDate": "Fri, 10 May 2024 18:22:00 +0530",
        "description": "Artificial intelligence (AI) is transforming cybersecurity, and those leading the charge are using it to outsmart increasingly advanced cyber threats. Join us for an exciting webinar, \"The Future of Threat Hunting is Powered by Generative AI,\" where you'll explore how AI tools are shaping the future of cybersecurity defenses. During the session, Censys Security Researcher Aidan Holland will",
        "link": "https://thehackernews.com/2024/05/censysgpt-ai-powered-threat-hunting-for.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Chrome Zero-Day Alert — Update Your Browser to Patch New Vulnerability",
        "pubDate": "Fri, 10 May 2024 15:53:00 +0530",
        "description": "Google on Thursday released security updates to address a zero-day flaw in Chrome that it said has been actively exploited in the wild. Tracked as CVE-2024-4671, the high-severity vulnerability has been described as a case of use-after-free in the Visuals component. It was reported by an anonymous researcher on May 7, 2024. Use-after-free bugs, which arise when a program",
        "link": "https://thehackernews.com/2024/05/chrome-zero-day-alert-update-your.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "What's the Right EDR for You? ",
        "pubDate": "Fri, 10 May 2024 15:52:00 +0530",
        "description": "A guide to finding the right endpoint detection and response (EDR) solution for your business’ unique needs. Cybersecurity has become an ongoing battle between hackers and small- and mid-sized businesses. Though perimeter security measures like antivirus and firewalls have traditionally served as the frontlines of defense, the battleground has shifted to endpoints. This is why endpoint",
        "link": "https://thehackernews.com/2024/05/whats-right-edr-for-you.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Malicious Android Apps Pose as Google, Instagram, WhatsApp to Steal Credentials",
        "pubDate": "Fri, 10 May 2024 15:51:00 +0530",
        "description": "Malicious Android apps masquerading as Google, Instagram, Snapchat, WhatsApp, and X (formerly Twitter) have been observed to steal users' credentials from compromised devices. \"This malware uses famous Android app icons to mislead users and trick victims into installing the malicious app on their devices,\" the SonicWall Capture Labs threat research team said in a recent report. The",
        "link": "https://thehackernews.com/2024/05/malicious-android-apps-pose-as-google.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Meet Kevin’s A.I. Friends",
        "pubDate": "Fri, 10 May 2024 09:04:59 +0000",
        "description": "They gave him notes on his outfits and reassurance before a big talk, and they shared made-up gossip about each other.",
        "link": "https://www.nytimes.com/2024/05/10/podcasts/hard-fork-ai-friends.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Researchers Uncover 'LLMjacking' Scheme Targeting Cloud-Hosted AI Models",
        "pubDate": "Fri, 10 May 2024 13:11:00 +0530",
        "description": "Cybersecurity researchers have discovered a novel attack that employs stolen cloud credentials to target cloud-hosted large language model (LLM) services with the goal of selling access to other threat actors. The attack technique has been codenamed LLMjacking by the Sysdig Threat Research Team. \"Once initial access was obtained, they exfiltrated cloud credentials and gained",
        "link": "https://thehackernews.com/2024/05/researchers-uncover-llmjacking-scheme.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Apple Says Destructive iPad Ad ‘Missed the Mark’",
        "pubDate": "Thu, 09 May 2024 22:10:03 +0000",
        "description": "People in the creative world widely panned a commercial showing a giant hydraulic press squishing objects ranging from paint cans to a piano.",
        "link": "https://www.nytimes.com/2024/05/09/technology/apple-ipad-ad-crush-apology.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "New TunnelVision Attack Allows Hijacking of VPN Traffic via DHCP Manipulation",
        "pubDate": "Thu, 09 May 2024 23:25:00 +0530",
        "description": "Researchers have detailed a Virtual Private Network (VPN) bypass technique dubbed TunnelVision that allows threat actors to snoop on victim's network traffic by just being on the same local network. The \"decloaking\" method has been assigned the CVE identifier CVE-2024-3661 (CVSS score: 7.6). It impacts all operating systems that implement a DHCP client and has",
        "link": "https://thehackernews.com/2024/05/new-tunnelvision-attack-allows.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Kremlin-Backed APT28 Targets Polish Institutions in Large-Scale Malware Campaign",
        "pubDate": "Thu, 09 May 2024 20:50:00 +0530",
        "description": "Polish government institutions have been targeted as part of a large-scale malware campaign orchestrated by a Russia-linked nation-state actor called APT28. \"The campaign sent emails with content intended to arouse the recipient's interest and persuade him to click on the link,\" the computer emergency response team, CERT Polska, said in a Wednesday bulletin. Clicking on the link",
        "link": "https://thehackernews.com/2024/05/kremlin-backed-apt28-targets-polish.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Meet My A.I. Friends",
        "pubDate": "Thu, 09 May 2024 14:36:07 +0000",
        "description": "Our columnist spent the past month hanging out with 18 A.I. companions. They critiqued his clothes, chatted among themselves and hinted at a very different future.",
        "link": "https://www.nytimes.com/2024/05/09/technology/meet-my-ai-friends.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "New Guide: How to Scale Your vCISO Services Profitably",
        "pubDate": "Thu, 09 May 2024 16:35:00 +0530",
        "description": "Cybersecurity and compliance guidance are in high demand among SMEs. However, many of them cannot afford to hire a full-time CISO. A vCISO can answer this need by offering on-demand access to top-tier cybersecurity expertise. This is also an opportunity for MSPs and MSSPs to grow their business and bottom line. MSPs and MSSPs that expand their offerings and provide vCISO services",
        "link": "https://thehackernews.com/2024/05/new-guide-how-to-scale-your-vciso.html"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " NYT Wordle today — answer and hints for game #1059, Monday, May 13 ",
        "pubDate": "Tue, 14 Feb 2023 09:56:57 +0000",
        "description": "Looking for Wordle hints? We can help. Plus get the answers to Wordle today and yesterday.",
        "link": "https://www.techradar.com/news/wordle-today"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Past Wordle answers – every solution so far, by date ",
        "pubDate": "Mon, 13 Feb 2023 08:15:05 +0000",
        "description": "Knowing past Wordle answers can help with today's game. Here's the full list so far.",
        "link": "https://www.techradar.com/news/past-wordle-answers"
      }
    ]
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.