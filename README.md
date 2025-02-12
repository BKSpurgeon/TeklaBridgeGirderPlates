# Tekla Bridge Girder Plates

### Explanation of the Code

This is a code sample that:

  1. Builds contour plates, with

  2. Bolts. ...with the contour plates being tapered. This required a tiny bit of linear algebra.

All the inputs are read in from a CSV file.

I had to add a report which tells us if the plates are not planar. The bolts are all aligned to the plane of the plates. They need to be fairly accurate - 10 microns to be precise - according to the infinite wisdom of the Victorian Government engineer.

Hopefully the code is clear enough to give you something to start with.

### Demo:

[![Demo of Code via Video](https://user-images.githubusercontent.com/15097447/172506873-02b15b12-cbcb-4021-b97c-5a137cc7b5ac.png)](https://vimeo.com/446339309?embedded=true&source=video_title&owner=20292870)

### Warning: Gripe Alert (Continue only if you like rants)

* We received an order to create bridge plate girders. 
* Victorian government engineer wanted these plates to a tolerance of 10 microns. Yes, you read that correctly.  But why this type of accuracy is necessary, or even possible, given we are building a bridge? 
* I must spent an additional 28 hours dealing with the back-and-forth rigmarole of dealing with these bureacurats and government engineers. I had to redo the entire job so that it reads to a 10 micron tolerance. Fix their erroneous data points. Did not get paid to fix their errors, and supply to their crazy specs. What a glorious waste of time and energy. Anyways, it's water under the Westgate bridge (pun intended).

Hopefully at least you gain something from the code. 



