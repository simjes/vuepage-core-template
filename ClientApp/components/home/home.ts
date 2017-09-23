import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import ProjectCard from '../project-card/project-card.vue';
import ProjectDetailsModal from '../project-details-modal/project-details-modal.vue';
import {ProjectType} from "../../helpers/ProjectTypes";
import { IProject } from "../../helpers/IProject";
import axios from 'axios';
var Parallax = require('vue-parallaxy');

declare var store: any;
declare var $: any;

@Component({
	components: { Parallax, ProjectCard, ProjectDetailsModal }
})
export default class HomeComponent extends Vue {
	projectDetails: IProject = {
		id: 0,
		title: "",
		description: "",
		imageUrl: "",
		thumbnailUrl: "",
		startDateTime: "",
		tags: [], 
		urlLocation: [], 
		projectType: ProjectType.Others
	};
	showMobile = true;
	showWeb = true;
	showBackend = true;
	showOthers = true;
	
	projects: IProject[] = [];

	created() {
		axios.get(`/api/project`)
			.then(response => {
				// JSON responses are automatically parsed.
				store.commit('addProjects', response.data);
				this.projects = response.data;
				console.log(response.data);
			})
			.catch(e => {
				console.log(e);
			});
		//$(':checkbox').radiocheck();
	}

	get filteredProjects() {
		return this.projects.filter((project) => {
			switch (project.projectType) {
			case ProjectType.Mobile:
				return this.showMobile;
			case ProjectType.Web:
				return this.showWeb;
			case ProjectType.Backend:
				return this.showBackend;
			case ProjectType.Others:
				return this.showOthers;
			default:
				return true;
			}
		});
	}

	get noProjects() {
		if (this.projects.length < 1) {
			return true;
		}
		return !this.showMobile && !this.showWeb && !this.showBackend && !this.showOthers;
	}

	setProject(project) {
		this.projectDetails = project;
	}
}
