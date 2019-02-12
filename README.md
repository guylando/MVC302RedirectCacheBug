# MVC302RedirectCacheBug
Reproducing bug described at https://github.com/aspnet/AspNetCore/issues/7436

NOTE: Must not be done from anonymous tab because then the browser doesn't use disk cache and bug does not occur.
NOTE: If chrome devtools are open then make sure that in network tab the "disable cache" checkbox is NOT checked.

Steps to reproduce:
1. Run the site and open http://localhost:5000 in chrome desktop.
2. Clear chrome cache and cookies and everything and then re-enter http://localhost:5000 (the goal is that in this step chrome disk cache caches the 302 redirect from http://localhost:5000 to http://localhost:5000/Home/A
3. Click the button to be transferred to B page.
4. Click the button to be transferred to A page.
5. Click the button to be transferred to B page.
6. Click browser back button will trigger infinite redirect bug.
