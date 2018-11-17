<template>
    <div class="container-fluid">
	    <div class="row">
		    <div class="col-12 bg-dark p-3 text-light">
		    	<h4 class="float-left mt-2">
		    		TEAM NAME
		    	</h4>
				<b-dropdown id="ddown-righ" text="Team management " class="float-right mt-1">
					<b-dropdown-item>
						<router-link to="/team/memberTypes" class="text-dark">User's types</router-link>
					</b-dropdown-item>
					<b-dropdown-item>
						<router-link to="/team/members" class="text-dark">Users</router-link>
					</b-dropdown-item>
					<b-dropdown-item>
						<router-link to="/team/tasks" class="text-dark">Tasks</router-link>
					</b-dropdown-item>
				</b-dropdown>
		    </div>
		    <div class="col-12 dashboardTopHeader p-5 text-light text-left">
		    	<div class="row align-items-center">
		    		<div class="col-md-12 col-lg-4 on-small">
				    	<div class="row">
				    		<div class="col-auto">
								<img src="/img/logo.png" width="50" class="mb-2" />
				    		</div>
				    		<div class="col-auto">
							    <h3>
							    	Jacek Kowalski<br/>
							    	<small>
							    		email@email.com
							    	</small>
							    </h3>
				    		</div>
					    </div>
				    	<small>
				    		<a href="#" class="btn btn-link">My profile</a>|
				    		<a href="#" class="btn btn-link">Settings</a>|
							<a href="#" class="btn btn-link text-danger">Logout</a>
				    	</small>
		    		</div>
		    		<div class="col-md-12 col-lg-8 ml-auto text-center">
				    	<div class="row to-right">
				    		<div class="col-md-3">
							    <h3 class="img-container">
                                    <img src="/img/icons/todo.png">
							    	<strong>120</strong><br/>
							    </h3>
                                <h3><small class="text-info">TO DO</small></h3>
				    		</div>
				    		<div class="col-md-3">
							    <h3 class="img-container">
                                    <img src="/img/icons/inprogress.png">
							    	<strong>2</strong><br/>
							    </h3>
                                <h3><small class="text-warning">IN PROGRESS</small></h3>
				    		</div>
				    		<div class="col-md-3">
							    <h3 class="img-container">
                                    <img src="/img/icons/done.png">
							    	<strong>1243</strong><br/>
							    </h3>
                                <h3><small class="text-success">DONE</small></h3>
				    		</div>
					    </div>
		    		</div>
			    </div>
		    </div>
	    </div>
    </div>
</template>

<script>
export default {};
</script>

<style scoped lang="scss">
.dashboardTopHeader {
  background: url(/img/app_bg.png) no-repeat center center;
  background-size: cover;
}
.img-container {
  position: relative;
  img {
    width: 50%;
    height: auto;
  }
  strong {
    position: absolute;
    top: 50%;
    left: 50%;
    -webkit-transform: translate(-50%, -50%); /* iOS */
    transform: translate(-50%, -50%);
  }
}
.to-right {
  justify-content: end;
}
@media only screen and (max-width: 975px) {
  .on-small {
    display: flex;
    flex-direction: column;
    text-align: center;
    .row {
      justify-content: center;
    }
  }
  .to-right {
    justify-content: center;
    margin-top: 20px;
  }
}

@media only screen and (max-width: 767px) {
  .img-container img {
    width: 25%;
  }
}

@media only screen and (max-width: 410px) {
  .img-container img {
    width: 35%;
  }
}
</style>
