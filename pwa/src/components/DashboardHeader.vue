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
		    		<div class="col-auto">
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
				    		<a href="#" class="btn btn-link">my profile</a>
				    		<a href="#" class="btn btn-link">settings</a>
							<a href="#" class="btn btn-link text-danger">Logout</a>
				    	</small>
		    		</div>
		    		<div class="col-auto ml-auto text-center">
				    	<div class="row">
				    		<div class="col-auto">
							    <h3>
							    	<strong>120</strong><br/>
							    	<small class="text-info">
							    		TO DO
							    	</small>
							    </h3>
				    		</div>
				    		<div class="col-auto">
							    <h3>
							    	<strong>2</strong><br/>
							    	<small class="text-warning">
							    		IN PROGRESS
							    	</small>
							    </h3>
				    		</div>
				    		<div class="col-auto">
							    <h3>
							    	<strong>1243</strong><br/>
							    	<small class="text-success">
							    		DONE
							    	</small>
							    </h3>
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

<style scoped>
.dashboardTopHeader {
  background: url(/img/app_bg.png) no-repeat center center;
  background-size: cover;

}
</style>
