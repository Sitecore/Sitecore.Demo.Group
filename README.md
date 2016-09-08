# Sitecore.Demo.Group
Habitat Group Demo site - A Developer Example of a Habitat Based Demo

To install, set up a website running:
* The [Habitat](https://github.com/sitecore/habitat) framework (For more information about the Habitat project, please check out the [Habitat Wiki](https://github.com/sitecore/habitat/wiki))

The code and scenarios in this repository is not generally supported and can be used as is.

For more information:

If you are a partner or customer, please contact your local Sitecore sales or partner representative.
For internal Sitecore support, please check the demo pages on HUB

## Setup
To set up the Habitat Group website locally:  

1. Install Sitecore and Webforms for Marketers in c:\websites on http://habitat.dev.local
2. Install Habitat onto the Sitecore installation following the habitat installation guidelines
3. Add the hostname group.dev.local to the binding on the IIS and in your local hosts file
4. Clone the Habitat Group Website repository from GitHub into c:/projects/sitecore.demo.group
5. Open a command line
    1. Change the command line to c:/projects/sitecore.demo.group
    2. Run “npm install” to install gulp and the required node modules in the folder
    3. Run “gulp” to build, publish and sync the Habitat Group website onto the Sitecore installation
6. Visit http://group.dev.local in your browser to view the Habitat group website
7. A rebuild of the Sitecore master search index might be needed. Please refer to the [Sitecore documentation](https://doc.sitecore.net/sitecore_experience_platform/setting_up__maintaining/search_and_indexing/indexing/rebuild_search_indexes).
