import {ProjectType} from './ProjectTypes';

export interface IProject {
	id: number,
	title: string,
	type: ProjectType,
}