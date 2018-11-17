<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-4 bg-dark text-light mb-4">
		    	<h2>
		    		Members
		    	</h2>
		    </div>
		    <div class="col-12 p-5">
			    <div class="row">
				    <div class="col-12 mb-3" v-for="member in membersNames">
						<router-link :to="{ path: '/team/memberDetails/' + member.id }" class="card text-left memberCard">
							<div class="card-body">
                                <img :src='member.avatarPath'>
								<h5 class="card-title">
									{{ member.firstname }} {{ member.lastname }}
								</h5>
								<!--<p class="card-text" v-for="roleName in member.assignedRole">-->
									<!--Assigned role: {{ roleName.name }}-->
									<!--<strong>-->
									<!--&lt;!&ndash;<span class="text-warning">250</span>, of which <span class="text-success">230</span> completed&ndash;&gt;-->
								<!--</strong>-->
								<!--</p>-->
							</div>
						</router-link>
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
      membersNames: "",
      roleName: ""
    };
  },
  components: {
    DashboardHeader: DashboardHeader,
    DashboardFooter: DashboardFooter
  },
  mounted: function() {
    let self = this;
    this.$axios
      .get("http://kathon.hackierz.com/Teams/one/1")
      .then(function(req) {
        self.membersNames = req.data.members.map(objects => {
          return objects;
        });
      });
  }
};
</script>

<style scoped lang="scss">
.dashboardTopHeader {
  background: url(/img/app_bg.png) no-repeat center center;
  background-size: cover;
}

.memberCard {
  text-decoration: none;
  color: initial;
  .card-body {
    display: flex;
  }
  img {
    width: 10%;
  }
  h5 {
    align-self: center;
    margin: 0;
  }
}

.memberCard:hover {
  text-decoration: none;
  color: initial;
  filter: drop-shadow(3px 6px 3px rgba(0, 0, 0, 0.6));
}
</style>
