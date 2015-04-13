


<!DOCTYPE html>
<html lang="en" class="">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>CSharp2015/Transaction.cs at master · UdaySrivastav/CSharp2015</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="UdaySrivastav/CSharp2015" name="twitter:title" /><meta content="Contribute to CSharp2015 development by creating an account on GitHub." name="twitter:description" /><meta content="https://avatars3.githubusercontent.com/u/5163077?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars3.githubusercontent.com/u/5163077?v=3&amp;s=400" property="og:image" /><meta content="UdaySrivastav/CSharp2015" property="og:title" /><meta content="https://github.com/UdaySrivastav/CSharp2015" property="og:url" /><meta content="Contribute to CSharp2015 development by creating an account on GitHub." property="og:description" />
      <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">
    <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="web-socket" href="wss://live.github.com/_sockets/NTE2MzA3Nzo2ODE5NmFhM2MyOTk3OWI4Yjg5OTE1YmZkYWJhZTdhNTpmYTBiNWE2MmFiYTQ4NTI1YWZmMTBjYjIyNDJhOTM1ZTQ2NTljNWM0NjEzZTFkMzYwMWExMzc3YTVkNWU5ODg4--b0e521f178a16d43877a7222f1eebe8f796dbcfe">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="898C71A1:2DE9:14F6765:55266F1C" name="octolytics-dimension-request_id" /><meta content="5163077" name="octolytics-actor-id" /><meta content="UdaySrivastav" name="octolytics-actor-login" /><meta content="e0741d92aa754133230b1179a82a7cca0b624552b429e39a3bf0cd816f39d7c4" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />
    <meta class="js-ga-set" name="dimension1" content="Logged In">
    <meta class="js-ga-set" name="dimension2" content="Header v3">
    <meta name="is-dotcom" content="true">
    <meta name="hostname" content="github.com">
    <meta name="user-login" content="UdaySrivastav">

    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="sTtooJU8ohQXraB+xVFNSTY5xeNuNi3oluGCLCwBO0DDDL7mfyPktWSTFMu10KtrVKytK2MiCFGOdqnTfQPasg==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-c27ba1dfa67445324bab49f8e0c263d3fd50fd4cb5797bbb03011d74bf7e8608.css" media="all" rel="stylesheet" />
    <link href="https://assets-cdn.github.com/assets/github2-5b5e999e041f2586f9dc06b940229076225e6ec5ab5406be292a87331325fdc0.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="789bdb6a3ae10922d200debfa735ab1c">

      
  <meta name="description" content="Contribute to CSharp2015 development by creating an account on GitHub.">
  <meta name="go-import" content="github.com/UdaySrivastav/CSharp2015 git https://github.com/UdaySrivastav/CSharp2015.git">

  <meta content="5163077" name="octolytics-dimension-user_id" /><meta content="UdaySrivastav" name="octolytics-dimension-user_login" /><meta content="33658033" name="octolytics-dimension-repository_id" /><meta content="UdaySrivastav/CSharp2015" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="33658033" name="octolytics-dimension-repository_network_root_id" /><meta content="UdaySrivastav/CSharp2015" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/UdaySrivastav/CSharp2015/commits/master.atom" rel="alternate" title="Recent Commits to CSharp2015:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      


        <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/UdaySrivastav/CSharp2015/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>

      <ul class="header-nav left" role="navigation">
          <li class="header-nav-item explore">
            <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
          </li>
            <li class="header-nav-item">
              <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
            </li>
            <li class="header-nav-item">
              <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
            </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
          </li>
      </ul>

      
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/UdaySrivastav" data-ga-click="Header, go to profile, text:username">
      <img alt="@UdaySrivastav" class="avatar" data-user="5163077" height="20" src="https://avatars3.githubusercontent.com/u/5163077?v=3&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">UdaySrivastav</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="#" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      <ul class="dropdown-menu">
        
<li>
  <a href="/new" data-ga-click="Header, create new repository, icon:repo"><span class="octicon octicon-repo"></span> New repository</a>
</li>
<li>
  <a href="/organizations/new" data-ga-click="Header, create new organization, icon:organization"><span class="octicon octicon-organization"></span> New organization</a>
</li>


  <li class="dropdown-divider"></li>
  <li class="dropdown-header">
    <span title="UdaySrivastav/CSharp2015">This repository</span>
  </li>
    <li>
      <a href="/UdaySrivastav/CSharp2015/issues/new" data-ga-click="Header, create new issue, icon:issue"><span class="octicon octicon-issue-opened"></span> New issue</a>
    </li>
    <li>
      <a href="/UdaySrivastav/CSharp2015/settings/collaboration" data-ga-click="Header, create new collaborator, icon:person"><span class="octicon octicon-person"></span> New collaborator</a>
    </li>

      </ul>
    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
        <span class="mail-status all-read"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="kSkXutkFaEP8W9Ds9ZEKVjAmEv1Qm4d9VtkceilWw3SwXlAr0EZ5paVbITHUENB8omXEuMniSEgM6S4cVhVZvw==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>



    
  </div>
</div>

        

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

  <li>
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="oYYTa96a0mpRZ6U5bA/h4tSxgabjvZMBY5UfXB0yRDu5OBU0socK3jFRvGbcyvADjKIwHSJlRgmlxH67zJUdCg==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="33658033" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/UdaySrivastav/CSharp2015/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#show">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Unwatch
          </span>
        </a>
        <a class="social-count js-social-count" href="/UdaySrivastav/CSharp2015/watchers">
          1
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="cQvt5zqLRH3P2alwRL7Q4WSC6kOWh60entRX8wD4n7xo+2vaEk+52zGmTm0RCxsueinW2fGtbUfH6gBTPlM3QQ==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar UdaySrivastav/CSharp2015"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/UdaySrivastav/CSharp2015/stargazers">
          0
        </a>
</form>
    <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="Xx82f5rccc9NhqEowdnACMbG4XIEtgYD6Au91uSrr/Z8CAqw7f7pceGNuatxGgMmJp3OB7UI99fqox03LafwFQ==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star UdaySrivastav/CSharp2015"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/UdaySrivastav/CSharp2015/stargazers">
          0
        </a>
</form>  </div>

  </li>

        <li>
          <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/fork" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="CWd3HWqJRbcRLtY3h4d3Wkyeraehba72YYKQMurXACySjqyTJkHSgjSPOmMvLMsqR5s7gsnzzOEe11Eh6ZMQ3Q==" /></div>
            <button
                type="submit"
                class="btn btn-sm btn-with-count"
                data-ga-click="Repository, show fork modal, action:blob#show; text:Fork"
                title="Fork your own copy of UdaySrivastav/CSharp2015 to your account"
                aria-label="Fork your own copy of UdaySrivastav/CSharp2015 to your account">
              <span class="octicon octicon-repo-forked"></span>
              Fork
            </button>
            <a href="/UdaySrivastav/CSharp2015/network" class="social-count">0</a>
</form>        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/UdaySrivastav" class="url fn" itemprop="url" rel="author"><span itemprop="title">UdaySrivastav</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/UdaySrivastav/CSharp2015" class="js-current-repository" data-pjax="#js-repo-pjax-container">CSharp2015</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/UdaySrivastav/CSharp2015/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/UdaySrivastav/CSharp2015" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /UdaySrivastav/CSharp2015">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/UdaySrivastav/CSharp2015/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /UdaySrivastav/CSharp2015/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/UdaySrivastav/CSharp2015/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /UdaySrivastav/CSharp2015/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Wiki">
        <a href="/UdaySrivastav/CSharp2015/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g w" data-selected-links="repo_wiki /UdaySrivastav/CSharp2015/wiki">
          <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>
  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/UdaySrivastav/CSharp2015/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /UdaySrivastav/CSharp2015/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/UdaySrivastav/CSharp2015/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /UdaySrivastav/CSharp2015/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>
  </ul>


    <div class="sunken-menu-separator"></div>
    <ul class="sunken-menu-group">
      <li class="tooltipped tooltipped-w" aria-label="Settings">
        <a href="/UdaySrivastav/CSharp2015/settings" aria-label="Settings" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_settings /UdaySrivastav/CSharp2015/settings">
          <span class="octicon octicon-tools"></span> <span class="full-word">Settings</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>
    </ul>
</nav>

              <div class="only-with-full-nav">
                  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/UdaySrivastav/CSharp2015.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:UdaySrivastav/CSharp2015.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/UdaySrivastav/CSharp2015" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



<p class="clone-options">You can clone with
  <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>, <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>, or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/UdaySrivastav/CSharp2015" class="btn btn-sm sidebar-button" title="Save UdaySrivastav/CSharp2015 to your computer and use it in GitHub Desktop." aria-label="Save UdaySrivastav/CSharp2015 to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>


                <a href="/UdaySrivastav/CSharp2015/archive/master.zip"
                   class="btn btn-sm sidebar-button"
                   aria-label="Download the contents of UdaySrivastav/CSharp2015 as a zip file"
                   title="Download the contents of UdaySrivastav/CSharp2015 as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/UdaySrivastav/CSharp2015/blob/5c21f2df061528c990bf20e7d76cceefbdb5b150/Calculator/Calculator/CheckBook/Transaction.cs" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:213eeeed429d7dd2b934dc6f8ccb088f -->

<div class="file-navigation js-zeroclipboard-container">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Find or create a branch…" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Find or create a branch…">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Find or create a branch…" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/UdaySrivastav/CSharp2015/blob/master/Calculator/Calculator/CheckBook/Transaction.cs"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/branches" class="js-create-branch select-menu-item select-menu-new-item-form js-navigation-item js-new-item-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="hNhy+RuS9LuiuNfsDq4mo0EK6hVG/HR070io7ruvYIRlK6PXD9Dvt7fKjlZ0euY3TUnp0UyTYSvSjZ9LudVYew==" /></div>
            <span class="octicon octicon-git-branch select-menu-item-icon"></span>
            <div class="select-menu-item-text">
              <span class="select-menu-item-heading">Create branch: <span class="js-new-item-name"></span></span>
              <span class="description">from ‘master’</span>
            </div>
            <input type="hidden" name="name" id="name" class="js-new-item-value">
            <input type="hidden" name="branch" id="branch" value="master">
            <input type="hidden" name="path" id="path" value="Calculator/Calculator/CheckBook/Transaction.cs">
</form>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

  <div class="btn-group right">
    <a href="/UdaySrivastav/CSharp2015/find/master"
          class="js-show-file-finder btn btn-sm empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s" data-copied-hint="Copied!" data-copy-hint="Copy file path to clipboard" type="button"><span class="octicon octicon-clippy"></span></button>
  </div>

  <div class="breadcrumb js-zeroclipboard-target">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/UdaySrivastav/CSharp2015" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp2015</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/UdaySrivastav/CSharp2015/tree/master/Calculator" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">Calculator</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/UdaySrivastav/CSharp2015/tree/master/Calculator/Calculator" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">Calculator</span></a></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/UdaySrivastav/CSharp2015/tree/master/Calculator/Calculator/CheckBook" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CheckBook</span></a></span><span class="separator">/</span><strong class="final-path">Transaction.cs</strong>
  </div>
</div>

<include-fragment class="commit commit-loader file-history-tease" src="/UdaySrivastav/CSharp2015/contributors/master/Calculator/Calculator/CheckBook/Transaction.cs">
  <div class="file-history-tease-header">
    Fetching contributors&hellip;
  </div>

  <div class="participation">
    <p class="loader-loading"><img alt="" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-EAF2F5-0bdc57d34b85c4a4de9d0d1db10cd70e8a95f33ff4f46c5a8c48b4bf4e5a9abe.gif" width="16" /></p>
    <p class="loader-error">Cannot retrieve contributors at this time</p>
  </div>
</include-fragment>
<div class="file">
  <div class="file-header">
    <div class="file-actions">

      <div class="btn-group">
        <a href="/UdaySrivastav/CSharp2015/raw/master/Calculator/Calculator/CheckBook/Transaction.cs" class="btn btn-sm " id="raw-url">Raw</a>
          <a href="/UdaySrivastav/CSharp2015/blame/master/Calculator/Calculator/CheckBook/Transaction.cs" class="btn btn-sm js-update-url-with-hash">Blame</a>
        <a href="/UdaySrivastav/CSharp2015/commits/master/Calculator/Calculator/CheckBook/Transaction.cs" class="btn btn-sm " rel="nofollow">History</a>
      </div>

        <a class="octicon-btn tooltipped tooltipped-nw"
           href="github-windows://openRepo/https://github.com/UdaySrivastav/CSharp2015?branch=master&amp;filepath=Calculator%2FCalculator%2FCheckBook%2FTransaction.cs"
           aria-label="Open this file in GitHub for Windows">
            <span class="octicon octicon-device-desktop"></span>
        </a>

            <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/edit/master/Calculator/Calculator/CheckBook/Transaction.cs" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="B1zDs+h5ZYDtDk1Z3WEndHmkrhucPIt81A4cKi0hTh8ivGHqKsg9p/FG8zYLH0QZT7jU3PXTub/xRnZKLlHzrg==" /></div>
              <button class="octicon-btn tooltipped tooltipped-n" type="submit" aria-label="Edit this file" data-hotkey="e" data-disable-with>
                <span class="octicon octicon-pencil"></span>
              </button>
</form>
          <form accept-charset="UTF-8" action="/UdaySrivastav/CSharp2015/delete/master/Calculator/Calculator/CheckBook/Transaction.cs" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="CwVS1e12gIwkJ6pcimDRqHuV4YLOb34JCFc6ACoQJkJdZXa1xOoS9hPn1ELzDZipmD7OLkmwkHYs0gLMrm3N1A==" /></div>
            <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-n" type="submit" aria-label="Delete this file" data-disable-with>
              <span class="octicon octicon-trashcan"></span>
            </button>
</form>    </div>

    <div class="file-info">
        91 lines (78 sloc)
        <span class="file-info-divider"></span>
      3.573 kb
    </div>
  </div>
  
  <div class="blob-wrapper data type-c">
      <table class="highlight tab-size-8 js-file-line-container">
      <tr>
        <td id="L1" class="blob-num js-line-number" data-line-number="1"></td>
        <td id="LC1" class="blob-code js-file-line"><span class="pl-k">using</span> System;</td>
      </tr>
      <tr>
        <td id="L2" class="blob-num js-line-number" data-line-number="2"></td>
        <td id="LC2" class="blob-code js-file-line"><span class="pl-k">using</span> System.Collections.Generic;</td>
      </tr>
      <tr>
        <td id="L3" class="blob-num js-line-number" data-line-number="3"></td>
        <td id="LC3" class="blob-code js-file-line"><span class="pl-k">using</span> System.Collections.ObjectModel;</td>
      </tr>
      <tr>
        <td id="L4" class="blob-num js-line-number" data-line-number="4"></td>
        <td id="LC4" class="blob-code js-file-line"><span class="pl-k">using</span> System.Linq;</td>
      </tr>
      <tr>
        <td id="L5" class="blob-num js-line-number" data-line-number="5"></td>
        <td id="LC5" class="blob-code js-file-line"><span class="pl-k">using</span> System.Text;</td>
      </tr>
      <tr>
        <td id="L6" class="blob-num js-line-number" data-line-number="6"></td>
        <td id="LC6" class="blob-code js-file-line"><span class="pl-k">using</span> System.Threading.Tasks;</td>
      </tr>
      <tr>
        <td id="L7" class="blob-num js-line-number" data-line-number="7"></td>
        <td id="LC7" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L8" class="blob-num js-line-number" data-line-number="8"></td>
        <td id="LC8" class="blob-code js-file-line"><span class="pl-k">namespace</span> <span class="pl-en">Calculator.CheckBook</span></td>
      </tr>
      <tr>
        <td id="L9" class="blob-num js-line-number" data-line-number="9"></td>
        <td id="LC9" class="blob-code js-file-line">{</td>
      </tr>
      <tr>
        <td id="L10" class="blob-num js-line-number" data-line-number="10"></td>
        <td id="LC10" class="blob-code js-file-line">    <span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">Transaction</span>: <span class="pl-k">BaseVM</span></td>
      </tr>
      <tr>
        <td id="L11" class="blob-num js-line-number" data-line-number="11"></td>
        <td id="LC11" class="blob-code js-file-line">    {</td>
      </tr>
      <tr>
        <td id="L12" class="blob-num js-line-number" data-line-number="12"></td>
        <td id="LC12" class="blob-code js-file-line">        <span class="pl-k">private</span> CheckBookVM _VM;</td>
      </tr>
      <tr>
        <td id="L13" class="blob-num js-line-number" data-line-number="13"></td>
        <td id="LC13" class="blob-code js-file-line">        <span class="pl-k">public</span> CheckBookVM VM</td>
      </tr>
      <tr>
        <td id="L14" class="blob-num js-line-number" data-line-number="14"></td>
        <td id="LC14" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L15" class="blob-num js-line-number" data-line-number="15"></td>
        <td id="LC15" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _VM; }</td>
      </tr>
      <tr>
        <td id="L16" class="blob-num js-line-number" data-line-number="16"></td>
        <td id="LC16" class="blob-code js-file-line">            <span class="pl-k">set</span> { _VM = <span class="pl-k">value</span>; OnPropertyChanged(); }</td>
      </tr>
      <tr>
        <td id="L17" class="blob-num js-line-number" data-line-number="17"></td>
        <td id="LC17" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L18" class="blob-num js-line-number" data-line-number="18"></td>
        <td id="LC18" class="blob-code js-file-line">        </td>
      </tr>
      <tr>
        <td id="L19" class="blob-num js-line-number" data-line-number="19"></td>
        <td id="LC19" class="blob-code js-file-line">        <span class="pl-k">private</span> DateTime _Date;</td>
      </tr>
      <tr>
        <td id="L20" class="blob-num js-line-number" data-line-number="20"></td>
        <td id="LC20" class="blob-code js-file-line">        <span class="pl-k">public</span> DateTime Date</td>
      </tr>
      <tr>
        <td id="L21" class="blob-num js-line-number" data-line-number="21"></td>
        <td id="LC21" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L22" class="blob-num js-line-number" data-line-number="22"></td>
        <td id="LC22" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _Date; }</td>
      </tr>
      <tr>
        <td id="L23" class="blob-num js-line-number" data-line-number="23"></td>
        <td id="LC23" class="blob-code js-file-line">            <span class="pl-k">set</span> { _Date = <span class="pl-k">value</span>; OnPropertyChanged(); }</td>
      </tr>
      <tr>
        <td id="L24" class="blob-num js-line-number" data-line-number="24"></td>
        <td id="LC24" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L25" class="blob-num js-line-number" data-line-number="25"></td>
        <td id="LC25" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L26" class="blob-num js-line-number" data-line-number="26"></td>
        <td id="LC26" class="blob-code js-file-line">        <span class="pl-k">private</span> <span class="pl-k">string</span> _Payee;</td>
      </tr>
      <tr>
        <td id="L27" class="blob-num js-line-number" data-line-number="27"></td>
        <td id="LC27" class="blob-code js-file-line">        <span class="pl-k">public</span> <span class="pl-k">string</span> Payee</td>
      </tr>
      <tr>
        <td id="L28" class="blob-num js-line-number" data-line-number="28"></td>
        <td id="LC28" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L29" class="blob-num js-line-number" data-line-number="29"></td>
        <td id="LC29" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _Payee; }</td>
      </tr>
      <tr>
        <td id="L30" class="blob-num js-line-number" data-line-number="30"></td>
        <td id="LC30" class="blob-code js-file-line">            <span class="pl-k">set</span> { _Payee = <span class="pl-k">value</span>; OnPropertyChanged(); }</td>
      </tr>
      <tr>
        <td id="L31" class="blob-num js-line-number" data-line-number="31"></td>
        <td id="LC31" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L32" class="blob-num js-line-number" data-line-number="32"></td>
        <td id="LC32" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L33" class="blob-num js-line-number" data-line-number="33"></td>
        <td id="LC33" class="blob-code js-file-line">        <span class="pl-k">private</span> <span class="pl-k">string</span> _Account;</td>
      </tr>
      <tr>
        <td id="L34" class="blob-num js-line-number" data-line-number="34"></td>
        <td id="LC34" class="blob-code js-file-line">        <span class="pl-k">public</span> <span class="pl-k">string</span> Account</td>
      </tr>
      <tr>
        <td id="L35" class="blob-num js-line-number" data-line-number="35"></td>
        <td id="LC35" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L36" class="blob-num js-line-number" data-line-number="36"></td>
        <td id="LC36" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _Account; }</td>
      </tr>
      <tr>
        <td id="L37" class="blob-num js-line-number" data-line-number="37"></td>
        <td id="LC37" class="blob-code js-file-line">            <span class="pl-k">set</span> { _Account = <span class="pl-k">value</span>; OnPropertyChanged(); <span class="pl-k">if</span> (VM != <span class="pl-c1">null</span>) VM.OnPropertyChanged(<span class="pl-s"><span class="pl-pds">&quot;</span>Accounts<span class="pl-pds">&quot;</span></span>); }</td>
      </tr>
      <tr>
        <td id="L38" class="blob-num js-line-number" data-line-number="38"></td>
        <td id="LC38" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L39" class="blob-num js-line-number" data-line-number="39"></td>
        <td id="LC39" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L40" class="blob-num js-line-number" data-line-number="40"></td>
        <td id="LC40" class="blob-code js-file-line">        <span class="pl-k">private</span> <span class="pl-k">double</span> _Amount;</td>
      </tr>
      <tr>
        <td id="L41" class="blob-num js-line-number" data-line-number="41"></td>
        <td id="LC41" class="blob-code js-file-line">        <span class="pl-k">public</span> <span class="pl-k">double</span> Amount</td>
      </tr>
      <tr>
        <td id="L42" class="blob-num js-line-number" data-line-number="42"></td>
        <td id="LC42" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L43" class="blob-num js-line-number" data-line-number="43"></td>
        <td id="LC43" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _Amount; }</td>
      </tr>
      <tr>
        <td id="L44" class="blob-num js-line-number" data-line-number="44"></td>
        <td id="LC44" class="blob-code js-file-line">            <span class="pl-k">set</span> { _Amount = <span class="pl-k">value</span>; OnPropertyChanged(); }</td>
      </tr>
      <tr>
        <td id="L45" class="blob-num js-line-number" data-line-number="45"></td>
        <td id="LC45" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L46" class="blob-num js-line-number" data-line-number="46"></td>
        <td id="LC46" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L47" class="blob-num js-line-number" data-line-number="47"></td>
        <td id="LC47" class="blob-code js-file-line">        <span class="pl-k">private</span> <span class="pl-k">string</span> _Tag;</td>
      </tr>
      <tr>
        <td id="L48" class="blob-num js-line-number" data-line-number="48"></td>
        <td id="LC48" class="blob-code js-file-line">        <span class="pl-k">public</span> <span class="pl-k">string</span> Tag</td>
      </tr>
      <tr>
        <td id="L49" class="blob-num js-line-number" data-line-number="49"></td>
        <td id="LC49" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L50" class="blob-num js-line-number" data-line-number="50"></td>
        <td id="LC50" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _Tag; }</td>
      </tr>
      <tr>
        <td id="L51" class="blob-num js-line-number" data-line-number="51"></td>
        <td id="LC51" class="blob-code js-file-line">            <span class="pl-k">set</span> { _Tag = <span class="pl-k">value</span>; OnPropertyChanged(); }</td>
      </tr>
      <tr>
        <td id="L52" class="blob-num js-line-number" data-line-number="52"></td>
        <td id="LC52" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L53" class="blob-num js-line-number" data-line-number="53"></td>
        <td id="LC53" class="blob-code js-file-line">        </td>
      </tr>
      <tr>
        <td id="L54" class="blob-num js-line-number" data-line-number="54"></td>
        <td id="LC54" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L55" class="blob-num js-line-number" data-line-number="55"></td>
        <td id="LC55" class="blob-code js-file-line">    }</td>
      </tr>
      <tr>
        <td id="L56" class="blob-num js-line-number" data-line-number="56"></td>
        <td id="LC56" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L57" class="blob-num js-line-number" data-line-number="57"></td>
        <td id="LC57" class="blob-code js-file-line">    <span class="pl-k">public</span> <span class="pl-k">class</span> <span class="pl-en">CheckBookVM</span>: <span class="pl-k">BaseVM</span></td>
      </tr>
      <tr>
        <td id="L58" class="blob-num js-line-number" data-line-number="58"></td>
        <td id="LC58" class="blob-code js-file-line">    {</td>
      </tr>
      <tr>
        <td id="L59" class="blob-num js-line-number" data-line-number="59"></td>
        <td id="LC59" class="blob-code js-file-line">        <span class="pl-k">private</span> ObservableCollection&lt;Transaction&gt; _Transactions;</td>
      </tr>
      <tr>
        <td id="L60" class="blob-num js-line-number" data-line-number="60"></td>
        <td id="LC60" class="blob-code js-file-line">        <span class="pl-k">public</span> ObservableCollection&lt;Transaction&gt; Transactions</td>
      </tr>
      <tr>
        <td id="L61" class="blob-num js-line-number" data-line-number="61"></td>
        <td id="LC61" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L62" class="blob-num js-line-number" data-line-number="62"></td>
        <td id="LC62" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> _Transactions; }</td>
      </tr>
      <tr>
        <td id="L63" class="blob-num js-line-number" data-line-number="63"></td>
        <td id="LC63" class="blob-code js-file-line">            <span class="pl-k">set</span> { _Transactions = <span class="pl-k">value</span>; OnPropertyChanged(); OnPropertyChanged(<span class="pl-s"><span class="pl-pds">&quot;</span>Accounts<span class="pl-pds">&quot;</span></span>); }</td>
      </tr>
      <tr>
        <td id="L64" class="blob-num js-line-number" data-line-number="64"></td>
        <td id="LC64" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L65" class="blob-num js-line-number" data-line-number="65"></td>
        <td id="LC65" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L66" class="blob-num js-line-number" data-line-number="66"></td>
        <td id="LC66" class="blob-code js-file-line">        <span class="pl-k">public</span> IEnumerable&lt;<span class="pl-k">string</span>&gt; Accounts</td>
      </tr>
      <tr>
        <td id="L67" class="blob-num js-line-number" data-line-number="67"></td>
        <td id="LC67" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L68" class="blob-num js-line-number" data-line-number="68"></td>
        <td id="LC68" class="blob-code js-file-line">            <span class="pl-k">get</span> { <span class="pl-k">return</span> Transactions.Select(t=&gt; t.Account).Distinct(); }</td>
      </tr>
      <tr>
        <td id="L69" class="blob-num js-line-number" data-line-number="69"></td>
        <td id="LC69" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L70" class="blob-num js-line-number" data-line-number="70"></td>
        <td id="LC70" class="blob-code js-file-line">        </td>
      </tr>
      <tr>
        <td id="L71" class="blob-num js-line-number" data-line-number="71"></td>
        <td id="LC71" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L72" class="blob-num js-line-number" data-line-number="72"></td>
        <td id="LC72" class="blob-code js-file-line">        <span class="pl-k">public</span> <span class="pl-k">void</span> <span class="pl-en">Fill</span>()</td>
      </tr>
      <tr>
        <td id="L73" class="blob-num js-line-number" data-line-number="73"></td>
        <td id="LC73" class="blob-code js-file-line">        {</td>
      </tr>
      <tr>
        <td id="L74" class="blob-num js-line-number" data-line-number="74"></td>
        <td id="LC74" class="blob-code js-file-line">            Transactions = <span class="pl-k">new</span> ObservableCollection&lt;Transaction&gt;( <span class="pl-k">new</span>[] {</td>
      </tr>
      <tr>
        <td id="L75" class="blob-num js-line-number" data-line-number="75"></td>
        <td id="LC75" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">07</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Checking<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Moshe<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">30</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L76" class="blob-num js-line-number" data-line-number="76"></td>
        <td id="LC76" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">05</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Checking<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Tim<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">130</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Auto<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L77" class="blob-num js-line-number" data-line-number="77"></td>
        <td id="LC77" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">06</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Checking<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Moshe<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">35</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L78" class="blob-num js-line-number" data-line-number="78"></td>
        <td id="LC78" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">03</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Checking<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Bracha<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">35</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L79" class="blob-num js-line-number" data-line-number="79"></td>
        <td id="LC79" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">02</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Checking<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Tim<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">20</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Auto<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L80" class="blob-num js-line-number" data-line-number="80"></td>
        <td id="LC80" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">07</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Credit<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Moshe<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">30</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L81" class="blob-num js-line-number" data-line-number="81"></td>
        <td id="LC81" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">06</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Credit<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Bracha<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">30.5</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L82" class="blob-num js-line-number" data-line-number="82"></td>
        <td id="LC82" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">05</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Credit<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Tim<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">130</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Auto<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L83" class="blob-num js-line-number" data-line-number="83"></td>
        <td id="LC83" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">04</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Credit<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Moshe<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">35</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L84" class="blob-num js-line-number" data-line-number="84"></td>
        <td id="LC84" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">03</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Credit<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Bracha<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">35</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L85" class="blob-num js-line-number" data-line-number="85"></td>
        <td id="LC85" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">06</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Checking<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Bracha<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">30.5</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Food<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L86" class="blob-num js-line-number" data-line-number="86"></td>
        <td id="LC86" class="blob-code js-file-line">                <span class="pl-k">new</span> Transaction { VM=<span class="pl-c1">this</span>, Date= <span class="pl-k">new</span> DateTime(<span class="pl-c1">2015</span>,<span class="pl-c1">04</span>,<span class="pl-c1">02</span>), Account=<span class="pl-s"><span class="pl-pds">&quot;</span>Credit<span class="pl-pds">&quot;</span></span>, Payee=<span class="pl-s"><span class="pl-pds">&quot;</span>Tim<span class="pl-pds">&quot;</span></span>, Amount=<span class="pl-c1">20</span>, Tag=<span class="pl-s"><span class="pl-pds">&quot;</span>Auto<span class="pl-pds">&quot;</span></span> },</td>
      </tr>
      <tr>
        <td id="L87" class="blob-num js-line-number" data-line-number="87"></td>
        <td id="LC87" class="blob-code js-file-line">            });</td>
      </tr>
      <tr>
        <td id="L88" class="blob-num js-line-number" data-line-number="88"></td>
        <td id="LC88" class="blob-code js-file-line">        }</td>
      </tr>
      <tr>
        <td id="L89" class="blob-num js-line-number" data-line-number="89"></td>
        <td id="LC89" class="blob-code js-file-line">    }</td>
      </tr>
      <tr>
        <td id="L90" class="blob-num js-line-number" data-line-number="90"></td>
        <td id="LC90" class="blob-code js-file-line">}</td>
      </tr>
</table>

  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" action="" class="js-jump-to-line-form" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="btn">Go</button>
</form></div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.09815s from github-fe117-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
    </ul>
  </div>
</div>


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents" placeholder=""></textarea>
      <div class="suggester-container">
        <div class="suggester fullscreen-suggester js-suggester js-navigation-container"></div>
      </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    
    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-2c8ae50712a47d2b83d740cb875d55cdbbb3fdbccf303951cc6b7e63731e0c38.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-47790cee6fddf7135caf6ed39b4fcc1aa7dd81dd9ef8935a0bda0da52615af41.js"></script>
      
      

  </body>
</html>

