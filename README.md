# Sitecore.Demo.Group
Habitat Group Demo site - A Developer Example of a Habitat Based Demo

To install, set up a website running:
* [Habitat 1.7](https://github.com/sitecore/habitat) (For more information about the Habitat project, please check out the [Habitat Wiki](https://github.com/sitecore/habitat/wiki))

The code and scenarios in this repository is maintained by Sitecore, but is provided "as is" and is unsupported. Please do not submit support tickets regarding Habitat or this repository.

For more information:

If you are a partner or customer, please contact your local Sitecore sales or partner representative.
For internal Sitecore support, please check the demo pages on HUB

## Setup
To set up the Habitat Group website locally:  

1. [Install Habitat](https://github.com/Sitecore/Habitat/wiki/01-Getting-Started) following the guidance in that solution
2. Add the hostname group.dev.local to the Habitat site's bindings in IIS, and in your local hosts file
3. Clone the Habitat Group Website repository from GitHub into c:/projects/sitecore.demo.group
4. Open a command line **as admin:**
    1. Navigate to the root of the sitecore.demo.group solution (default c:/projects/sitecore.demo.group)
    2. Run **`npm install`** to install gulp and the required node modules in the folder
    3. Run **`gulp`** to build, publish and sync the Habitat Group website onto the Sitecore installation
5. Visit http://group.dev.local in your browser to view the Habitat group website
6. A rebuild of the Sitecore master search index might be needed. Please refer to the [Sitecore documentation](https://doc.sitecore.net/sitecore_experience_platform/setting_up__maintaining/search_and_indexing/indexing/rebuild_search_indexes).
