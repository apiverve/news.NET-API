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
var queryOptions = new newsQueryOptions {
  category = "technology"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "date": "2024-05-15",
    "category": "technology",
    "articleCount": 60,
    "articles": [
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "An A.I. Robot Named Sophia Tells Graduates to Believe in Themselves",
        "pubDate": "Wed, 15 May 2024 21:44:12 +0000",
        "description": "D’Youville University in Buffalo had an A.I. robot speak at its commencement on Saturday. Not everyone was happy about it.",
        "link": "https://www.nytimes.com/2024/05/15/nyregion/dyouville-university-commencement-robot-speaker.html"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "I demoed Google's Project Astra and it felt like the future of generative AI (until it didn't)",
        "pubDate": "Wed, 15 May 2024 21:20:00 +0000",
        "description": "The company's vision of multimodal AI looks promising, but it'll need to smooth out some wrinkles before officially launching.",
        "link": "https://www.zdnet.com/article/i-demoed-googles-project-astra-and-it-felt-like-the-future-of-generative-ai-until-it-didnt/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Where are floppy disks today? Planes, trains, and all these other places",
        "pubDate": "Wed, 15 May 2024 21:19:36 +0000",
        "description": "No, really! Floppy drives still live on in many surprising places, and not just the homes of die-hard techies.",
        "link": "https://www.zdnet.com/article/where-are-floppy-disks-today-planes-trains-and-all-these-other-places/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " iOS 17.5 is reportedly resurfacing once deleted photos for some users ",
        "pubDate": "Wed, 15 May 2024 21:15:00 +0000",
        "description": "A new iPhone bug is reportedly resurfacing images for some users.",
        "link": "https://www.techradar.com/computing/software/ios-175-is-reportedly-resurfacing-once-deleted-photos-for-some-users"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "These earbuds sound way too good for their price point. And that's not even their best feature",
        "pubDate": "Wed, 15 May 2024 21:14:00 +0000",
        "description": "The new Sennheiser Accentum True Wireless earbuds have audiophile-grade sound that sounds lush and premium, but at a mid-range price point. Plus, they're actually (no, seriously) comfortable to wear.",
        "link": "https://www.zdnet.com/article/these-earbuds-sound-way-too-good-for-their-price-point-and-thats-not-even-their-best-feature/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Arizona accuses Amazon of being a monopoly and deceiving consumers with ‘dark patterns’",
        "pubDate": "2024-05-15T21:08:56Z",
        "description": "Illustration by Alex Castro / The Verge          Arizona Attorney General Kris Mayes filed two new lawsuits against Amazon on Wednesday, bringing similar complaints to those the company is already facing from the Federal Trade Commission. Both of the lawsuits are brought under Arizona’s own state statutes in the Superior Court of Arizona. One of the lawsuits accuses Amazon of engaging in deceptive business practices that violate the state’s Consumer Fraud Act by allegedly using design tricks known as dark patterns to keep users from canceling their Amazon Prime subscriptions. This is similar to a lawsuit the FTC filed against the company in June. The other lawsuit accuses Amazon of breaking Arizona’s Uniform State Antitrust Act by unfairly maintaining monopoly status by enforcing... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157542/arizona-amazon-sues-deceptive-practices-antitrust-prime-buy-box"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Android 15 unveiled: Here are 8 exciting (or handy) features coming to your phone",
        "pubDate": "Wed, 15 May 2024 21:00:00 +0000",
        "description": "At I/O 2024, Google introduced more Android 15 features to the world. Here's what Android fans have to look forward to.",
        "link": "https://www.zdnet.com/article/android-15-unveiled-here-are-8-new-exciting-features-coming-to-your-phone/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Android 15’s second beta release lets users lock down access to private apps",
        "pubDate": "2024-05-15T20:59:37Z",
        "description": "Image: Google          Alongside Google’s ongoing developer-focused I/O conference comes the latest release of Android 15, which is now in its second beta. It’s got some cool new features, like the ability to now hide a collection of apps inside a “private space,” customizable vibrations so you can notice different types of notifications just by feeling, and also richer widget previews. The new private space function is the most interesting of the bunch: it can hide apps you don’t want others seeing into a biometric or PIN-protected container in the app drawer. It’s one of several new security features coming to Android.                   GIF: Google       Accessing a private space.     Private space leverages Android’s user profiles, so apps that you put in a... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157574/android-15-beta-2-release-private-space-rich-widgets"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "Generative AI can transform customer experiences. But only if you focus on other areas first",
        "pubDate": "Wed, 15 May 2024 20:49:15 +0000",
        "description": "AI can help staff focus on the most important customer concerns, so long as the business has a tight grip on its data.",
        "link": "https://www.zdnet.com/article/generative-ai-can-transform-customer-experiences-but-only-if-you-focus-on-other-areas-first/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "AI Program Aims to Break Barriers for Female Students",
        "pubDate": "Wed, 15 May 2024 20:38:13 +0000",
        "description": "A new program, backed by Cornell Tech, M.I.T. and U.C.L.A., helps prepare lower-income, Latina and Black female computing majors for artificial intelligence careers.",
        "link": "https://www.nytimes.com/2024/05/15/technology/ai-internships-female-students-cornell-mit-ucla.html"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Microsoft’s AI obsession is jeopardizing its climate ambitions        ",
        "pubDate": "2024-05-15T20:29:27Z",
        "description": "Microsoft CEO Satya Nadella delivers a speech during an event called Microsoft Build: AI Day in Kuala Lumpur, Malaysia, on May 2nd, 2024. | Photo by MOHD RASFAN / AFP via Getty Images          Microsoft’s producing a lot more planet-heating pollution now than it did when it made a bold climate pledge back in 2020. Its greenhouse gas emissions were actually around 30 percent higher in fiscal year 2023, showing how hard it could be for the company to meet climate goals as it simultaneously races to be a leader in AI.  Training and running AI models is an increasingly energy-hungry endeavor, and the impact that’s having on the climate is just starting to come into view. Microsoft’s latest sustainability report is a good case study in the conundrum facing big tech companies that made a slew of climate pledges in recent years but could wind up polluting more as they turn their focus to AI. “In many ways the moon is five times as... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157496/microsoft-ai-carbon-footprint-greenhouse-gas-emissions-grow-climate-pledge"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Apple's next accessibility features let you control your iPhone and iPad with just your eyes ",
        "pubDate": "Wed, 15 May 2024 20:26:43 +0000",
        "description": "Ahead of Global Accessibility Awareness Day, Apple is previewing new features like eye-tracking, vocal shortcuts, and music haptics that will arrive later this year.",
        "link": "https://www.techradar.com/computing/software/apples-next-accessibility-features-let-you-control-your-iphone-and-ipad-with-just-your-eyes"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "AT&T cuts a deal to launch satellite-to-smartphone service soon",
        "pubDate": "2024-05-15T20:20:41Z",
        "description": "Illustration: The Verge          AST SpaceMobile has ramped up demonstrations of voice calls, texts, and video calls via satellite over the last year, using 4G LTE and 5G connections with download bandwidth reaching 14Mbps. Now the company says that a previous memorandum of understanding with AT&T to work on a space-based broadband network for phones has become a “definitive commercial agreement,” just in time for AST’s first five commercial satellites to launch this summer. The FCC has gotten things rolling on a framework (PDF) for companies interested in building these types of services, with the idea of what Chairwoman Jessica Rosenworcel called a single network future. “We won’t need to think about what network, where, and what services are available. Connections... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157607/att-ast-spacemobile-satellite-cellular-network"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Best iPad to Buy (and Some to Avoid) in 2024",
        "pubDate": "Wed, 15 May 2024 20:17:51 +0000",
        "description": "New iPads are here. We break down Apple’s current lineup to help you figure out which one of Apple's tablets is best for you.",
        "link": "https://www.wired.com/gallery/the-best-ipad/"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "The best 85-inch TVs of 2024: Expert tested and reviewed",
        "pubDate": "Wed, 15 May 2024 20:07:40 +0000",
        "description": "We tested the best 85-inch TVs with bright screens, OLED panels, and 4K resolution from LG, Samsung, and Sony to help you choose the right one.",
        "link": "https://www.zdnet.com/home-and-office/home-entertainment/best-85-inch-tv/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Microsoft announces the Proteus Controller, a gamepad for Xbox gamers with disabilities",
        "pubDate": "2024-05-15T19:57:59Z",
        "description": "Image: ByoWave          On Wednesday, Microsoft announced the Proteus Controller, a $299 modular video game controller kit that lets Xbox gamers with disabilities customize their controllers.  Created by peripheral company ByoWave as part of the Designed for Xbox program, the wireless controller consists of small cubes with interchangeable faceplates that include controller buttons, a directional pad, and analog sticks.  The “snap and play” parts connect together so gamers can build more than 100 configurations and LED lighting variations. As a result, one-handed gamers and other players with disabilities can use the controller in a way that’s most comfortable for them. The buttons are also remappable for a more individualized experience, albeit only via the... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157529/microsoft-proteus-controller-xbox-accessibility"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Prepare to Get Manipulated by Emotionally Expressive Chatbots",
        "pubDate": "Wed, 15 May 2024 19:56:27 +0000",
        "description": "The emotional mimicry of OpenAI’s new version of ChatGPT could lead AI assistants in some strange—even dangerous—directions.",
        "link": "https://www.wired.com/story/prepare-to-get-manipulated-by-emotionally-expressive-chatbots/"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "The best VPN services of 2024: Expert tested and reviewed",
        "pubDate": "Wed, 15 May 2024 19:50:46 +0000",
        "description": "We tested the best VPNs available and ranked them based on speed, security, and features, for all of your private browsing and streaming needs.",
        "link": "https://www.zdnet.com/article/best-vpn/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Here are the best Apple Watch deals right now",
        "pubDate": "2024-05-15T19:43:07Z",
        "description": "The entry-level Apple Watch SE is a gateway smartwatch if there ever was one. | Photo by Amelia Holowaty Krales / The Verge          In September, Apple launched its latest batch of smartwatches, introducing the Apple Watch Ultra 2 ($799) alongside the Apple Watch Series 9 ($399). Each wearable has its own pros and cons, as does the second-gen Apple Watch SE ($249), but the introduction of the new wearables also means there are now more Apple Watch models on the market than ever before — and a lot more deals to be had.    But with all of those options, which one should you pick? Generally speaking, you want to buy the newest watch you can afford so that it continues to receive software updates from Apple. The latest update, watchOS 10, launched in September on the Apple Watch Series 4 and newer, though no one can say with certainty whether the Series 4 will get the next... Continue reading…",
        "link": "https://www.theverge.com/21289209/best-apple-watch-deals"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Netflix and the N.F.L. Sign a Three-Season Deal",
        "pubDate": "Wed, 15 May 2024 19:42:28 +0000",
        "description": "Football joins pro wrestling and comedy specials in an expansion of the streaming service’s live offerings, a key step in the company’s overall live TV strategy.",
        "link": "https://www.nytimes.com/2024/05/15/business/media/netflix-nfl-live.html"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "New in Android, Project Gameface lets you navigate your phone hands-free",
        "pubDate": "Wed, 15 May 2024 19:30:21 +0000",
        "description": "Developed for gaming, Google's tool is coming to Android 15 to help make everyday life more accessible.",
        "link": "https://www.zdnet.com/article/new-in-android-project-gameface-lets-you-navigate-your-phone-hands-free/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "The Suunto Race sports watch does it all, but its beefy display comes in first place",
        "pubDate": "Wed, 15 May 2024 19:17:00 +0000",
        "description": "Suunto's new Race sports watch has a gorgeous AMOLED display and all the fitness metrics you could ask for. But one feature skipped a beat.",
        "link": "https://www.zdnet.com/article/the-suunto-race-sports-watch-does-it-all-but-its-beefy-display-comes-in-first-place/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "Latest news",
        "title": "This small Bluetooth speaker is secretly a powerhouse with room-shaking audio",
        "pubDate": "Wed, 15 May 2024 19:16:00 +0000",
        "description": "The Tribit XSound Plus 2 may look unassuming, but its companion app makes it sound like a speaker twice the price.",
        "link": "https://www.zdnet.com/home-and-office/home-entertainment/tribit-has-another-hit-on-its-hands-with-the-xsound-plus-2-bluetooth-speaker/#ftag=RSSbaffb68"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Netflix renews 3 Body Problem for second season",
        "pubDate": "2024-05-15T19:15:06Z",
        "description": "Image: Netflix          3 Body Problem is getting a second season. Netflix announced the news that its adaptation of Cixin Liu’s award-winning sci-fi trilogy is getting more episodes, with David Benioff, D.B. Weiss, and Alexander Woo returning as executive producers and writers. 3 Body Problem follows a group of scientists as they struggle with the realization that humanity isn’t the only species in the universe and that its nearest neighbors are far more technologically advanced and very mean. It stars an ensemble cast featuring Liam Cunningham, Rosalind Chao, Zine Tseng, and Benedict Wong. Though the 3 Body Problem book trilogy spans several centuries, through cryogenic shenanigans, most characters from the present-day timeline should remain throughout the... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157514/3-body-problem-season-2-renewal-netflix"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "Netflix’s ad tier hits 40 million users",
        "pubDate": "2024-05-15T19:15:00Z",
        "description": "Illustration by Nick Barclay / The Verge          Netflix’s expansion into an ad-supported model seems to be a hit. Today, at its 2024 upfront presentation, the streamer said that it now has 40 million monthly users on its ad-supported tier globally. That’s up from 23 million earlier in the year; it took six months for the option to hit 5 million users after it launched in 2022. As of April, the service had a total of 270 million subscribers across all tiers. Netflix also said that, in regions where ads are available, more than 40 percent of new users are signing up for the ad-supported tier.   As part of announcing the milestone, Netflix revealed that it’s planning to launch “an in-house advertising technology platform.” In a statement, Netflix’s president of advertising, Amy Reinhard,... Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157487/netflixs-ad-tier-40-million-subscribers"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " LG's new super-bright OLED panel could give the next Meta Quest an edge over the Apple Vision Pro ",
        "pubDate": "Wed, 15 May 2024 19:00:29 +0000",
        "description": "LG's new OLEDoS panel boasts some superb specs that should help a future Meta Quest VR headset unbeatable visuals.",
        "link": "https://www.techradar.com/computing/virtual-reality-augmented-reality/lgs-new-super-bright-oled-panel-could-give-the-next-meta-quest-an-edge-over-the-apple-vision-pro"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "PPSSPP brings PSP emulation to the iPhone",
        "pubDate": "2024-05-15T18:42:48Z",
        "description": "Screenshot: PPSSPP          It’s the PlayStation Portable’s turn to get an emulator on the iOS App Store thanks to PPSSPP, which just went live today. This emulator, from developer Henrik Rydgård, has been in development for more than a decade, and it’s free to download for the iPhone and iPad. Rydgård says in a blog post that the version approved this morning has some limitations versus previous builds of the app that were available through various exploits and workarounds. The biggest is that Apple doesn’t allow Just-in-Time recompilers that retranslate code for the OS and can lead to smoother performance. (It’s why we might never see a GameCube / Wii emulator.) “Fortunately,” he writes, “iOS devices are generally fast enough” for almost all PSP games. Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157286/ppsspp-playstation-portable-psp-emulator-ios-app-store-iphone-ipad-apple"
      },
      {
        "category": "technology",
        "website": "The Verge -  All Posts",
        "title": "RetroArch brings its free multisystem emulation to the iOS App Store",
        "pubDate": "2024-05-15T18:31:28Z",
        "description": "Is this the best use of RetroArch? | Screenshot: RetroArch          Another emulator with tons of history and development, RetroArch, is now freely available on the iOS App Store today. This is great news for retro gaming fans with iPhones because it can emulate a truly eye-crossing number of retro consoles once installed. In fact, there are too many to list here. But some notable emulation cores — the actual separately developed emulation software — included in this version of RetroArch are the NEC PC Engine, Nintendo DS, Game Boy Advance, Virtual Boy, Neo Geo Pocket, and even the PSP (using the same core that drives the PPSSPP app that went up today). You can see the list in full by clicking “more” on RetroArch’s description in its App Store listing. Screen recording: RetroArch       J...    Continue reading…",
        "link": "https://www.theverge.com/2024/5/15/24157472/retroarch-emulator-ios-app-store-iphone-nintendo-sega-playstation-atari"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "FBI Seizes BreachForums Again, Urges Users to Report Criminal Activity",
        "pubDate": "Wed, 15 May 2024 23:22:00 +0530",
        "description": "Law enforcement agencies have officially seized control of the notorious BreachForums platform, an online bazaar known for peddling stolen data, for the second time within a year. The website (\"breachforums[.]st\") has been replaced by a seizure banner stating the clearnet cybercrime forum is under the control of the Federal Bureau of Investigation (FBI).  The operation is the",
        "link": "https://thehackernews.com/2024/05/fbi-seizes-breachforums-again-urges.html"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Saunas Are the Next Frontier in Fighting Depression",
        "pubDate": "Wed, 15 May 2024 17:48:03 +0000",
        "description": "The preliminary results of a clinical trial of using heat exposure to combat depression are in—and are fueling cautious optimism that sauna practice could become an accepted treatment.",
        "link": "https://www.wired.com/story/sauna-heat-therapy-depression-cbt-mental-health-trial/"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Good news for Mac users wanting to run Windows apps: VMware Fusion Pro 13 is now free for personal use ",
        "pubDate": "Wed, 15 May 2024 17:33:18 +0000",
        "description": "VMware has waived its $200 fee for the Fusion Pro 13 app on macOS which emulates Windows.",
        "link": "https://www.techradar.com/computing/mac-os/good-news-for-mac-users-wanting-to-run-windows-apps-vmware-fusion-pro-13-is-now-free-for-personal-use"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Firefox 126 is out – and it’ll make a huge difference to the quality of videos in the browser, for those with the right hardware ",
        "pubDate": "Wed, 15 May 2024 17:11:34 +0000",
        "description": "You’re going to want to grab the new browser as it could supercharge your video viewing experience.",
        "link": "https://www.techradar.com/computing/firefox/firefox-126-is-out-and-itll-make-a-huge-difference-to-the-quality-of-videos-in-the-browser-for-those-with-the-right-hardware"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Google Launches AI-Powered Theft and Data Protection Features for Android Devices",
        "pubDate": "Wed, 15 May 2024 22:30:00 +0530",
        "description": "Google has announced a slew of privacy and security features in Android, including a suite of advanced protection features to help secure users' devices and data in the event of a theft. These features aim to help protect data before, during and after a theft attempt, the tech giant said, adding they are expected to be available via an update to Google Play services for devices running",
        "link": "https://thehackernews.com/2024/05/google-adds-ai-powered-theft-protection.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Android 15 Rolls Out Advanced Features to Protect Users from Scams and Malicious Apps",
        "pubDate": "Wed, 15 May 2024 22:30:00 +0530",
        "description": "Google is unveiling a set of new features in Android 15 to prevent malicious apps installed on the device from capturing sensitive data. This constitutes an update to the Play Integrity API that third-party app developers can take advantage of to secure their applications against malware. \"Developers can check if there are other apps running that could be capturing the screen, creating",
        "link": "https://thehackernews.com/2024/05/android-15-introduces-new-features-to.html"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Android Update: Theft Detection Lock Knows When Your Phone Is Stolen",
        "pubDate": "Wed, 15 May 2024 17:00:00 +0000",
        "description": "Google is introducing new AI-powered safety tools in Android 15 that can lock down your phone if thieves nab it.",
        "link": "https://www.wired.com/story/android-15-theft-detection-lock/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "All the New Features Coming to Android Phones, Watches, and TVs This Year",
        "pubDate": "Wed, 15 May 2024 17:00:00 +0000",
        "description": "At I/O, Google showed off new features in Android 15, the latest version of Wear OS, improvements to Google TV, and more.",
        "link": "https://www.wired.com/story/google-io-android-ecosystem-updates-new-features/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "15 Top New Android 15 Features (2024): How to Install, Features, Release Date",
        "pubDate": "Wed, 15 May 2024 17:00:00 +0000",
        "description": "Android 15 is creeping closer to its release date. Here are the notable features and upgrades Google has in store.",
        "link": "https://www.wired.com/story/how-to-download-android-15-and-features/"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " PC gaming on an Android device? Fallout 4 has been shown running decently fast in an exciting hint of the future ",
        "pubDate": "Wed, 15 May 2024 16:24:58 +0000",
        "description": "Winlator emulator is now able to run demanding software such as Fallout 4 at 30 fps on Android.",
        "link": "https://www.techradar.com/computing/pc-gaming-on-an-android-device-fallout-4-has-been-shown-running-decently-fast-in-an-exciting-hint-of-the-future"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Could ChromeOS eventually run on your Android phone? Google’s demo of exactly that is an exciting hint for the future ",
        "pubDate": "Wed, 15 May 2024 16:09:44 +0000",
        "description": "Google has held a secret demo showcasing ChromeOS running on an Android device, hinting at potential future plans.",
        "link": "https://www.techradar.com/computing/software/could-chromeos-eventually-run-on-your-android-phone-googles-demo-of-exactly-that-is-an-exciting-hint-for-the-future"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Google One VPN now has a funeral date ",
        "pubDate": "Wed, 15 May 2024 15:37:39 +0000",
        "description": "Google One’s VPN service is being discontinued on June 20, 2024. This means you have about a month to find a suitable Android VPN alternative.",
        "link": "https://www.techradar.com/computing/cyber-security/google-one-vpn-now-has-a-funeral-date"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Google's answer to OpenAI's Sora has landed – here's how to get on the waitlist ",
        "pubDate": "Wed, 15 May 2024 14:57:01 +0000",
        "description": "Google's just revealed a promising generative AI video tool called Veo –and its waitlist is now open.",
        "link": "https://www.techradar.com/computing/artificial-intelligence/googles-answer-to-openais-sora-has-landed-heres-how-to-get-on-the-waitlist"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "These Electric School Buses Are on Their Way to Save the Grid",
        "pubDate": "Wed, 15 May 2024 14:00:00 +0000",
        "description": "Loaded with ever more renewables, the grid will need to store a whole lot of energy. Enter: a new kind of magic school bus—one that can both charge and give power back.",
        "link": "https://www.wired.com/story/these-electric-school-buses-are-on-their-way-to-save-the-grid/"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Best Cheap Electric Bikes Under $2,000 (2024): Commuter, Folding, Cargo",
        "pubDate": "Wed, 15 May 2024 13:30:00 +0000",
        "description": "Zip zap zoom! After months of testing, these are our favorite electric bikes that won’t break the bank.",
        "link": "https://www.wired.com/gallery/best-cheap-electric-bikes/"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Smartphones Can Now Last 7 Years. Here’s How to Keep Them Working.",
        "pubDate": "Wed, 15 May 2024 13:00:21 +0000",
        "description": "Google and Samsung used to update smartphone software for only three years. That has changed.",
        "link": "https://www.nytimes.com/2024/05/15/technology/personaltech/smartphones-software-update-ios-android.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Turla Group Deploys LunarWeb and LunarMail Backdoors in Diplomatic Missions",
        "pubDate": "Wed, 15 May 2024 17:59:00 +0530",
        "description": "An unnamed European Ministry of Foreign Affairs (MFA) and its three diplomatic missions in the Middle East were targeted by two previously undocumented backdoors tracked as LunarWeb and LunarMail. ESET, which identified the activity, attributed it with medium confidence to the Russia-aligned cyberespionage group Turla (aka Iron Hunter, Pensive Ursa, Secret Blizzard, Snake, Uroburos, and Venomous",
        "link": "https://thehackernews.com/2024/05/turla-group-deploys-lunarweb-and.html"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Microsoft PowerToys Is the Ultimate Windows 11 Customization Tool",
        "pubDate": "Wed, 15 May 2024 12:00:00 +0000",
        "description": "Microsoft’s own PowerToys utility can help you unlock the full potential of the Windows desktop.",
        "link": "https://www.wired.com/story/microsoft-powertoys-ultimate-tweaking-kit-for-windows-11/"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "(Cyber) Risk = Probability of Occurrence x Damage ",
        "pubDate": "Wed, 15 May 2024 17:08:00 +0530",
        "description": "Here’s How to Enhance Your Cyber Resilience with CVSS In late 2023, the Common Vulnerability Scoring System (CVSS) v4.0 was unveiled, succeeding the eight-year-old CVSS v3.0, with the aim to enhance vulnerability assessment for both industry and the public. This latest version introduces additional metrics like safety and automation to address criticism of lacking granularity while",
        "link": "https://thehackernews.com/2024/05/get-cyber-resilient-with-cvss.html"
      },
      {
        "category": "technology",
        "website": "Wired",
        "title": "Despite Bird Flu Risk, Raw-Milk Drinkers Are Undaunted",
        "pubDate": "Wed, 15 May 2024 11:30:00 +0000",
        "description": "As H5N1 continues its spread among US cow herds, raw milk enthusiasts remain utterly unfazed.",
        "link": "https://www.wired.com/story/raw-milk-drinkers-h5n1-bird-flu/"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Ebury Botnet Malware Compromises 400,000 Linux Servers Over Past 14 Years",
        "pubDate": "Wed, 15 May 2024 16:26:00 +0530",
        "description": "A malware botnet called Ebury is estimated to have compromised 400,000 Linux servers since 2009, out of which more than 100,000 were still compromised as of late 2023. The findings come from Slovak cybersecurity firm ESET, which characterized it as one of the most advanced server-side malware campaigns for financial gain. \"Ebury actors have been pursuing monetization activities [...],",
        "link": "https://thehackernews.com/2024/05/ebury-botnet-malware-compromises-400000.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "It's Time to Master the Lift & Shift: Migrating from VMware vSphere to Microsoft Azure",
        "pubDate": "Wed, 15 May 2024 16:25:00 +0530",
        "description": "While cloud adoption has been top of mind for many IT professionals for nearly a decade, it’s only in recent months, with industry changes and announcements from key players, that many recognize the time to make the move is now. It may feel like a daunting task, but tools exist to help you move your virtual machines (VMs) to a public cloud provider – like Microsoft Azure",
        "link": "https://thehackernews.com/2024/05/its-time-to-master-lift-shift-migrating.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Inside OpenAI’s Library",
        "pubDate": "Wed, 15 May 2024 09:00:50 +0000",
        "description": "OpenAI may be changing how the world interacts with language. But inside headquarters, there is a homage to the written word: a library.",
        "link": "https://www.nytimes.com/2024/05/15/technology/openai-library-office.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Senators Propose $32 Billion in Annual A.I. Spending but Defer Regulation",
        "pubDate": "Wed, 15 May 2024 09:00:06 +0000",
        "description": "Their plan is the culmination of a yearlong listening tour on the dangers of the new technology.",
        "link": "https://www.nytimes.com/2024/05/15/technology/ai-schumer-roadmap-congress.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Dutch Court Sentences Tornado Cash Co-Founder to 5 Years in Prison for Money Laundering",
        "pubDate": "Wed, 15 May 2024 13:58:00 +0530",
        "description": "A Dutch court on Tuesday sentenced one of the co-founders of the now-sanctioned Tornado Cash cryptocurrency mixer service to 5 years and 4 months in prison. While the name of the defendant was redacted in the verdict, it's known that Alexey Pertsev, a 31-year-old Russian national, has been awaiting trial in the Netherlands on money laundering charges.",
        "link": "https://thehackernews.com/2024/05/dutch-court-sentences-tornado-cash-co.html"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "Microsoft Patches 61 Flaws, Including Two Actively Exploited Zero-Days",
        "pubDate": "Wed, 15 May 2024 12:47:00 +0530",
        "description": "Microsoft has addressed a total of 61 new security flaws in its software as part of its Patch Tuesday updates for May 2024, including two zero-days which have been actively exploited in the wild. Of the 61 flaws, one is rated Critical, 59 are rated Important, and one is rated Moderate in severity. This is in addition to 30 vulnerabilities&",
        "link": "https://thehackernews.com/2024/05/microsoft-patches-61-flaws-including.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Few Chinese Electric Cars Are Sold in U.S., but Industry Fears a Flood",
        "pubDate": "Wed, 15 May 2024 04:00:06 +0000",
        "description": "Automakers in the United States and their supporters welcomed President Biden’s tariffs, saying they would protect domestic manufacturing and jobs from cheap Chinese vehicles.",
        "link": "https://www.nytimes.com/2024/05/15/business/economy/china-electric-vehicles-biden-tariffs.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "OpenAI’s Chief Scientist, Ilya Sutskever, Is Leaving the Company",
        "pubDate": "Wed, 15 May 2024 01:39:05 +0000",
        "description": "In November, Ilya Sutskever joined three other OpenAI board members to force out Sam Altman, the chief executive, before saying he regretted the move.",
        "link": "https://www.nytimes.com/2024/05/14/technology/ilya-sutskever-leaving-openai.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Google Unveils AI Overviews Feature for Search at 2024 I/O Conference",
        "pubDate": "Wed, 15 May 2024 00:12:49 +0000",
        "description": "The tech giant showed off how it would enmesh A.I. more deeply into its products and users’ lives, from search to so-called agents that perform tasks.",
        "link": "https://www.nytimes.com/2024/05/14/technology/google-artificial-intelligence-products.html"
      },
      {
        "category": "technology",
        "website": "NYT > Technology",
        "title": "Can Google Give A.I. Answers Without Breaking the Web?",
        "pubDate": "Tue, 14 May 2024 18:16:58 +0000",
        "description": "Publishers have long worried that artificial intelligence would drive readers away from their sites. They’re about to find out if those fears are warranted.",
        "link": "https://www.nytimes.com/2024/05/14/technology/google-ai-answers.html"
      },
      {
        "category": "technology",
        "website": " TechRadar - All the latest technology news ",
        "title": " Proton Mail recovery email leads to arrest of Catalan activist ",
        "pubDate": "Tue, 14 May 2024 16:38:27 +0000",
        "description": "Proton Mail is under fire for disclosing user data that led to the arrest of an activist in Spain. However, the secure email service is still safe when used properly.",
        "link": "https://www.techradar.com/computing/cyber-security/proton-mail-hands-data-to-police-again-is-it-still-safe-for-activists"
      },
      {
        "category": "technology",
        "website": "The Hacker News",
        "title": "VMware Patches Severe Security Flaws in Workstation and Fusion Products",
        "pubDate": "Tue, 14 May 2024 21:19:00 +0530",
        "description": "Multiple security flaws have been disclosed in VMware Workstation and Fusion products that could be exploited by threat actors to access sensitive information, trigger a denial-of-service (DoS) condition, and execute code under certain circumstances. The four vulnerabilities impact Workstation versions 17.x and Fusion versions 13.x, with fixes available in version 17.5.2 and",
        "link": "https://thehackernews.com/2024/05/vmware-patches-severe-security-flaws-in.html"
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

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.