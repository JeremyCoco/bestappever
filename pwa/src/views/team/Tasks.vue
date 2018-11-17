<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-4 bg-dark text-light mb-4">
		    	<h2>
		    		Current Tasks
		    	</h2>
		    </div>
		    <div class="col-12 pb-5">
			    <div class="row">
				    <div class="col-12 mb-3">
						<div class="card text-left" v-for="task in tasks">
							<div class="card-body">
								<strong class="float-right">
									{{ task.createdAt | formatDate }}
								</strong>
								<h5 class="card-title">{{ task.title }}</h5>
								<p class="card-text">
									{{ task.username }}
								</p>
								<router-link :to="{ path: '/team/taskDetails/' + task.id }" class="btn btn-primary">Go to details</router-link>
							</div>
						</div>
				    </div>
			    </div>
		    </div>
		    <DashboardFooter />
	    </div>
    </div>
</template>

<script>
import DashboardHeader from "@/components/DashboardHeader";
import DashboardFooter from "@/components/DashboardFooter";

export default {
  data: () => {
    return {
      tasks: ""
    };
  },
  components: {
    DashboardHeader: DashboardHeader,
    DashboardFooter: DashboardFooter
  },
  mounted: function() {
    let self = this;
    this.$axios
      .get("http://kathon.hackierz.com/Teams/One/1")
      .then(function(req) {
        self.tasks = req.data.tasks.map(objects => {
          return objects;
        });
      });
  }
};
</script>

<style scoped>
.dashboardTopHeader {
  background: url(/img/app_bg.png) no-repeat center center;
  background-size: cover;
}
</style>
