import PropTypes from 'prop-types';

const UserTable = ({ users, ages }) => {
    return (
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Age</th>
                    <th>Age in 20 Years</th>
                    <th>Favourite Colour</th>
                </tr>
            </thead>

            <tbody>
                {
                    users.map((u) => {
                        let filter = ages.filter((a) => { return a.userId === u.id });
                        let userAge = filter[0];

                        return (
                            <tr key={u.id}>
                                <td>{u.firstName} {u.lastName}</td>
                                <td>{u.email}</td>
                                <td>{userAge.originalAge}</td>
                                <td>{userAge.agePlusTwenty}</td>
                                <td>{u.favouriteColour}</td>
                            </tr>
                        );
                    })
                }
            </tbody>
        </table>
    );
}
UserTable.propTypes = {
    users: PropTypes.arrayOf(PropTypes.object).isRequired,
    ages: PropTypes.arrayOf(PropTypes.object)
};

export default UserTable;