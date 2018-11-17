<template>
	<div class="container-fluid">
		<div class="row align-items-center screenContainer">
			<div class="col">
				<div class="row text-center">
					<div class="col-auto mx-auto pt-5">
						<h1 class="text-light">
							<img src="/img/logo.png" width="40" class="mb-2" />
							Be Your Best
						</h1>
						<div class="smallDividerBlock"></div>
					</div>
				</div>
				<div class="row text-white">
					<div class="col">
						<div class="form-group mt-5">
							<label>
								GROUP NAME
							</label>
							<input type="text" class="form-control" v-model="teamName" />
						</div>
						<button @click="findTeam(teamName)"
						class="btn btn-primary">
							FIND
						</button>

						<p class="mb-0 mt-4">
							Can't find your team?
						</p>
						<router-link to="/Auth/Team/Create" tag="button" class="btn btn-link">CREATE NEW</router-link>

						<div class="smallDividerBlock mt-5"></div>
						<p class="text-justify mt-3 text-light">
							<small>
                                Administratorem danych osobowych jest grupa projektowa Tragic Bytes w składzie: Bartosz Bernaś, Marek Bubiak oraz Anna Bernaś. Projekt powstał na hackathonie organizowanym przez firmę Euvic, w dniach 16-17 listopada 2018 roku w Gliwicach. Proszę nie czytać dalszego tekstu, gdyż są to farmazony. Blaeo naio naosdoa anjioa 771293 383903 noab;al. Anabja. Bosajb as  ahifafia ahioaw 2820000 29928 28 nlabh abifasdihds lisdla hia rbrus abehdue ah. Mahuahbap ahuiab au huaibdhia huiahi.
                            </small>
						</p>
						<router-link to="/" tag="button" class="btn btn-sm btn-link">BACK TO HOME</router-link>
					</div>
				</div>
			</div>
		</div>
        <b-modal ref="teamRef" hide-footer title="Time not found">
            <div class="d-block text-center">
                <h3>The team that you looking for doesnt exist. Click below to create new.</h3>
            </div>
            <b-btn class="mt-3" variant="outline-danger" block @click="hideModal">Create Team</b-btn>
        </b-modal>
	</div>
</template>

<script>
import firebase from "firebase";
import { db } from "../db";

export default {
  data: () => {
    return {
      teamName: ""
    };
  },
  mounted: function() {},
  firebase: {
    teams: db.ref("teams")
  },
  methods: {
    findTeam(teamName) {
      let isTeam = false;
      let self = this;
      this.$firebaseRefs.teams
        .once("value")
        .then(function(snapshot) {
          snapshot.forEach(function(childSnapshot) {
            let childData = childSnapshot.val();
            if (childData.name === teamName) {
              self.$router.push(`/Auth/Team/${teamName}/Login`);
              isTeam = true;
            }
          });
        })
        .then(function() {
          if (!isTeam) {
            self.$refs.teamRef.show();
          }
        });
    },
    hideModal() {
      this.$refs.teamRef.hide();
      this.$router.push(`/Auth/Team/Create`);
    }
  }
};
</script>

<style scoped>
</style>
